#ifndef NETWORK_H
#define NETWORK_H

void sendUint32(int, uint32_t);
void recvUint32(int, uint32_t *);
void sendByteArray(int, const unsigned char *, uint32_t);
void recvByteArray(int, unsigned char **, uint32_t *);
void sendString(int, const char *);
void recvString(int, char **);

#endif
