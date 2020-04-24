#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <dirent.h>
#include <server/files.h>

long
getFileSize(FILE *f)
{
	fseek(f, 0, SEEK_END);
	const long size = ftell(f);
	rewind(f);
	return size;
}

unsigned char *
getFileContents(FILE *f)
{
	const long size = getFileSize(f);
	unsigned char *ret = malloc(size);
	fread(ret, 1, size, f);
	return ret;
}

char *
getFilesList(const char *path)
{
	DIR *dir = opendir(path);

	if (!dir) {
		fprintf(stderr, "Error: can't open directory \"%s\".\n", path);
		return NULL;
	}

	char *ret = NULL;

	for (struct dirent *e; (e = readdir(dir)) != NULL; ) {
		if (e->d_type == DT_REG) {
			const size_t  retLength       =  ret ? strlen(ret) : 0;
			const size_t  fileNameLength  =  strlen(e->d_name);

			ret = realloc(ret, retLength + fileNameLength + 2);

			strcat(ret, e->d_name);
			strcat(ret, "\n");
		}
	}

	closedir(dir);
	return ret;
}
