leaf <- read.table("data/leaf2-4.txt", head = TRUE, as.is = TRUE, sep=";")

str(leaf)

forma <- ts(leaf$FORM, frequency = 36)

str(forma)
acf(forma)
plot(stl(forma, s.window = "periodic")$time.series)
