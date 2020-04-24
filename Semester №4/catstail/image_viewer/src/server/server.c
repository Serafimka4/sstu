#define _GNU_SOURCE

#include <stdio.h>
#include <string.h>
#include <stdlib.h>
#include <unistd.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <server/files.h>
#include <common/network.h>
#include <common/port.h>

int
main(int argc, char *argv[])
{
	//======================
	// A directory with images should be passed to the server
	// program via command line.
	//=====================

	if (argc != 2) {
		fprintf(stderr, "Usage: server <image-directory>.\n");
		exit(EXIT_FAILURE);
	}

	//========================
	// Create a server socket and a structure that holds the
	// server address.
	//========================

	const int serverSocket = socket(AF_INET, SOCK_STREAM, 0);

	const struct sockaddr_in serverAddress = {
		.sin_family = AF_INET,
		.sin_port = htons(APP_PORT),
		.sin_addr = {
			.s_addr = INADDR_ANY
		}
	};

	//=========================
	// Assigns an address to the socket.
	//=========================

	bind(serverSocket, (const struct sockaddr *) &serverAddress, sizeof(serverAddress));

	//============================
	// Wait for the client connection.
	//============================

	listen(serverSocket, 1);
	const int clientSocket = accept(serverSocket, NULL, NULL);

	//=========================
	// Application's main logic.
	//========================

	char *imageDirectory = argv[1];

	char *filesList = getFilesList(imageDirectory);
	sendString(clientSocket, filesList);

	char *fileName;
	recvString(clientSocket, &fileName);

	char *filePath;
	asprintf(&filePath, "%s/%s", imageDirectory, fileName);

	FILE *file = fopen(filePath, "rb");

	if (!file) {
		fprintf(stderr, "Error: can't open file \"%s\".\n", filePath);
		exit(EXIT_FAILURE);
	}

	unsigned char *fileContent = getFileContents(file);
	sendByteArray(clientSocket, fileContent, getFileSize(file));

	//==========================
	// Free the resources.
	//==========================

	free(fileContent);
	free(fileName);
	free(filePath);
	free(filesList);
	fclose(file);
	close(serverSocket);
	close(clientSocket);
}
