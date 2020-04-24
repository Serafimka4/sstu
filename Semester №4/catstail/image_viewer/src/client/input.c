#include <stdio.h>
#include <string.h>
#include <client/input.h>

void
getLineFromUser(char **output)
{
	size_t length;
	getline(output, &length, stdin);

	// Remove the new line character that the getline function
	// includes to the result string.
	*strchr(*output, '\n') = '\0';
}
