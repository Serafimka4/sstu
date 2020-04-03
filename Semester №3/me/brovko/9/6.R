forma <- ts(nhtemp, frequency=1)
acf(forma, main="")
plot(stl(forma, s.window="periodic")$time.series, main="")
