cmake_minimum_required(VERSION 3.16)
project(ImageViewer C)

set(CMAKE_C_STANDARD 99)

find_package(SDL2 REQUIRED)
include_directories(${SDL2_INCLUDE_DIRS})

include_directories(include)
include_directories(include/common)
include_directories(include/server)

add_executable(client
        include/common/network.h
        include/common/port.h
	include/common/min.h
        include/client/graphics.h
	include/client/input.h
        src/common/network.c
        src/client/client.c
        src/client/graphics.c
	src/client/input.c)

target_link_libraries(client
	SDL2
	SDL2_image
)

add_executable(server
        include/common/network.h
        include/common/port.h
        include/server/files.h
        src/common/network.c
        src/server/server.c
        src/server/files.c
)
