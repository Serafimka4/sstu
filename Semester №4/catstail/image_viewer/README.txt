A CLIENT-SERVER IMAGE VIEWER
============================

BUILDING
--------

In order to build the application CMake, GNU Make, SDL, SDL_Image and
a C99 compiler with GNU extensions are required. The viewer uses the POSIX
API and the standard C Libary, so it can run on any POSIX-compliant OS.

Run the following commands to build the application:

	$ mkdir build
	$ cd build
	$ cmake ..
	$ make

USAGE
-----

First, start the server and pass to it a directory with images as a command
line argument:

	$ build/server images

Second, start the client in other shell:

	$ build/client
