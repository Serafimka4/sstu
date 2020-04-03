ts(1:10, frequency = 4, start = c(1959, 2))

z <- ts(matrix(rnorm(300), 100, 3), start = c(1961, 1), frequency = 12)

plot(z, plot.type = "single", lty = 1:3)
