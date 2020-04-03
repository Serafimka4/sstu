lm.cars <- lm(formula = dist ~ speed, data = cars)

b0 <- lm.cars$coefficients[1]
b1 <- lm.cars$coefficients[2]

x1 <- min(cars$speed)
x2 <- max(cars$speed)

x <- seq(from = x1, to = x2, length.out = 100)
y <- b0 + b1 * x

plot(x = cars$speed, y = cars$dist, xlab = "Скорость, миль в час", ylab = "Тормозной путь, футы")

lines(x, y, col = "blue")

cars.loess <- loess.smooth(cars$speed, cars$dist, lty = 1)
lines(cars.loess, col = "red")
