#include <string.h>
#include <stdlib.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <common/network.h>
#include <common/min.h>

#define PACKAGE_SIZE 65536

static void sendRawData(int, const unsigned char *, uint32_t);
static void recvRawData(int, unsigned char *, uint32_t);

void
sendString(int socket, const char *s)
{
	sendByteArray(socket, s, strlen(s) + 1);
}

void
recvString(int socket, char **s)
{
	uint32_t dummy;
	recvByteArray(socket, (unsigned char **) s, &dummy);
}

void
sendByteArray(int socket, const unsigned char *array, uint32_t size)
{
	sendUint32(socket, size);
	sendRawData(socket, array, size);
}

void
recvByteArray(int socket, unsigned char **pointerToArray, uint32_t *size)
{
	recvUint32(socket, size);

	*pointerToArray = malloc(*size);
	recvRawData(socket, *pointerToArray, *size);
}

void
sendRawData(int socket, const unsigned char *data, uint32_t dataSize)
{
	for (size_t sentSize = 0; sentSize != dataSize; ) {
		const size_t remainingSize  = dataSize - sentSize;
		const size_t sizeToSend     = MIN(PACKAGE_SIZE, remainingSize);

		sentSize += send(socket, data + sentSize, sizeToSend, 0);
	}
}

void
recvRawData(int socket, unsigned  char *buffer, uint32_t dataSize)
{
	for (size_t receivedSize = 0; receivedSize != dataSize; ) {
		const size_t remainingSize = dataSize - receivedSize;
		const size_t sizeToReceive = MIN(PACKAGE_SIZE, remainingSize);

		receivedSize += recv(socket, buffer + receivedSize, sizeToReceive, 0);
	}
}

void
sendUint32(int socket, uint32_t hostData)
{
	const uint32_t netData = htonl(hostData);

	unsigned char rawData[4];
	memcpy(rawData, &netData, 4);

	send(socket, rawData, sizeof rawData, 0);
}

void
recvUint32(int socket, uint32_t *hostData)
{
	char rawData[4];
	recv(socket, rawData, sizeof rawData, 0);

	uint32_t netData;
	memcpy(&netData, rawData, sizeof netData);

	*hostData = ntohl(netData);
}
