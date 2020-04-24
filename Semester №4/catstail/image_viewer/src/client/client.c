#include <stdio.h>
#include <stdlib.h>
#include <unistd.h>
#include <netinet/in.h>
#include <sys/socket.h>
#include <common/network.h>
#include <common/port.h>
#include <client/graphics.h>
#include <client/input.h>

int
main(void)
{
	//========================
	// Create a client socket and a structure that holds the
	// server address.
	//========================

	const int clientSocket = socket(AF_INET, SOCK_STREAM, 0);

	const struct sockaddr_in serverAddress = {
		.sin_family = AF_INET,
		.sin_port = htons(APP_PORT),
		.sin_addr = {
			.s_addr = INADDR_ANY
		}
	};

	//==========================
	// Try to connect to the server.
	//==========================

	const int isConnected = connect(clientSocket, (const struct sockaddr *) &serverAddress, sizeof(serverAddress));

	if (isConnected == -1) {
		fprintf(stderr, "Error: can't connect to the server.\n");
		exit(EXIT_FAILURE);
	}

	//=========================
	// Application's main logic.
	//========================

	char *filesList;
	recvString(clientSocket, &filesList);

	printf("%s\nType the file name: ", filesList);

	char *fileName;
	getLineFromUser(&fileName);

	sendString(clientSocket, fileName);

	uint32_t fileSize;
	unsigned char *fileContent;
	recvByteArray(clientSocket, &fileContent, &fileSize);

	createWindowAndShowImage(fileContent, fileSize);

	//==========================
	// Free the resources.
	//==========================

	free(filesList);
	free(fileContent);
	free(fileName);
	close(clientSocket);
}
