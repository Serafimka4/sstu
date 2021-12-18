target := index

all:
	pdflatex $(target).tex
	biber $(target).bcf
	pdflatex $(target).tex

clean:
	$(RM) $(target).{log,aux,pdf,bcf,toc,run.xml,aux.bbl,aux.blg,bbl,blg} missfont.log

mostlyclean:
	$(RM) $(target).{log,aux,bcf,toc,run.xml,bbl,blg} missfont.log

run:
	zathura $(target).pdf || chromium $(target).pdf

.DELETE_ON_ERROR:
.PHONY: all clean mostlyclean run
