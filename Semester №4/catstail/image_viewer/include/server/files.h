#ifndef FILES_H
#define FILES_H

char            *getFilesList(const char *);
unsigned char   *getFileContents(FILE *);
long             getFileSize(FILE *);

#endif
