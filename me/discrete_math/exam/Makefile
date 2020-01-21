BUILD_DIR = build
DOCUMENT_BASE_NAME = discrete_math

SRC_DIR = src
VPATH = $(SRC_DIR)

.PHONY: clean run

all: pdf

pdf:
	mkdir -p $(BUILD_DIR)
	pdflatex -output-directory=$(BUILD_DIR) $(SRC_DIR)/$(DOCUMENT_BASE_NAME).tex

clean:
	-rm -f $(BUILD_DIR)/$(DOCUMENT_BASE_NAME).aux $(BUILD_DIR)/$(DOCUMENT_BASE_NAME).log

run: pdf
	zathura $(BUILD_DIR)/$(DOCUMENT_BASE_NAME).pdf
