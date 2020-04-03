CC := mcs
LIBS := -r:System.Windows.Forms.dll -r:System.Drawing.dll -r:System.Data.dll

SRCDIR := Src
SRC := $(wildcard $(SRCDIR)/*.cs)

RESDIR := Resources
RESOURCES := -resource:$(RESDIR)/SecondPractice.Form1.resources -resource:$(RESDIR)/SecondPractice.Form2.resources

BUILDIR := Build
TARGET := $(BUILDIR)/SecondPractice.exe

$(TARGET):
	$(CC) $(LIBS) $(RESOURCES) $(SRC) -out:$@

.PHONY: run
run: $(TARGET)
	exec $<

.PHONY: clean
clean:
	$(RM) $(TARGET)
