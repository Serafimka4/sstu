lm.iris <- lm(formula = Petal.Length ~ Petal.Width, data = iris)

b0 <- lm.iris$coefficients[1]
b1 <- lm.iris$coefficients[2]

x1 <- min(iris$Petal.Width)
x2 <- max(iris$Petal.Width)

x <- seq(from = x1, to = x2, length.out = 100)
y <- b0 + b1 * x

plot(x = iris$Petal.Width, y = iris$Petal.Length, xlab = "Petal.Width", ylab = "Petal.Length")
lines(x, y, col = "red")
