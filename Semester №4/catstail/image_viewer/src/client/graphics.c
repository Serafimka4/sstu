#include <SDL2/SDL.h>
#include <SDL2/SDL_image.h>
#include <client/graphics.h>
#include <common/min.h>

#define IMAGE_MAX_WIDTH 640

static void           drawImage(SDL_Renderer *, SDL_Texture *, unsigned int, unsigned int);
static SDL_Surface   *createSurfaceFromMemory(unsigned char *, size_t);
static float          getSurfaceAspectRatio(SDL_Surface *);
static void           showImageUntilWindowIsClosed(SDL_Renderer *, SDL_Texture *, unsigned int, unsigned int);

void
createWindowAndShowImage(unsigned char *imgBytes, size_t imgSize)
{
	SDL_Init(SDL_INIT_VIDEO);

	SDL_Window *window;
	SDL_Renderer *renderer;
	SDL_CreateWindowAndRenderer(IMAGE_MAX_WIDTH, IMAGE_MAX_WIDTH, 0, &window, &renderer);

	SDL_Surface          *surface          = createSurfaceFromMemory(imgBytes, imgSize);
	SDL_Texture          *texture          = SDL_CreateTextureFromSurface(renderer, surface);
	const float           imgAspectRatio   = getSurfaceAspectRatio(surface);
	const unsigned int    imgWidth         = MIN(IMAGE_MAX_WIDTH, surface->w);
	const unsigned int    imgHeight        = imgWidth * imgAspectRatio;

	SDL_SetWindowSize(window, imgWidth, imgHeight);
	showImageUntilWindowIsClosed(renderer, texture, imgWidth, imgHeight);

	SDL_DestroyRenderer(renderer);
	SDL_DestroyWindow(window);
	SDL_Quit();
}

void
showImageUntilWindowIsClosed(SDL_Renderer *renderer, SDL_Texture *texture, unsigned int w, unsigned int h)
{
	SDL_Event e;

	do {
		drawImage(renderer, texture, w, h);

		SDL_WaitEvent(&e);
	} while (e.type != SDL_QUIT);
}

void
drawImage(SDL_Renderer *renderer, SDL_Texture *texture, unsigned int w, unsigned int h)
{
	SDL_Rect rect = {0, 0, w, h};
	SDL_RenderCopy(renderer, texture, NULL, &rect);
	SDL_RenderPresent(renderer);
}

SDL_Surface *
createSurfaceFromMemory(unsigned char *data, size_t size)
{
	SDL_RWops *rw = SDL_RWFromMem(data, size);
	return IMG_Load_RW(rw, 1);
}

float
getSurfaceAspectRatio(SDL_Surface *s)
{
	return (float) s->h / (float) s->w;
}
