CC := mcs
LIBS := -r:System.Windows.Forms.dll -r:System.Drawing.dll -r:System.Data.dll

SRCDIR := Src
SRC := $(wildcard $(SRCDIR)/*.cs)

RESDIR := Resources
RESOURCES := $(shell for i in $(RESDIR)/*; do echo -resource:$$i; done)

BUILD_DIR := Build
TARGET := $(BUILD_DIR)/ThirdPractice.exe

$(TARGET): $(BUILD_DIR)
	$(CC) $(LIBS) $(RESOURCES) $(SRC) -out:$@

$(BUILD_DIR):
	mkdir -p $@

.PHONY: run
run: $(TARGET)
	exec $<

.PHONY: distclean
distclean:
	$(RM) -r $(BUILD_DIR)

.PHONY: clean
clean:
	$(RM) $(TARGET)
