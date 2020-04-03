leaf <- read.table("data/leaf2-4.txt", head = TRUE, as.is = TRUE, sep=";")

forma <- ts(leaf$FORM, frequency = 36)

acf(forma)
plot(stl(forma, s.window = "periodic")$time.series)
