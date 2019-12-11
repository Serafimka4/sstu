# Преобразование в метрическую систему:
women.metr <- women
women.metr$height <- 0.0254 * women.metr$height
women.metr$weight <- 0.45359237 * women.metr$weight

# Вычисление параметров уравнения регрессии:
lm.women <- lm(formula = weight ~ height, data = women.metr)

# Вывод модельных значений:
b0 <- lm.women$coefficient[1]
b1 <- lm.women$coefficient[2]

x1 <- min(women.metr$height)
x2 <- max(women.metr$height)

x <- seq(from = x1, to = x2, length.out =100)
y <- b0 + b1 * x

# Вывод графика зависимости:
plot(women.metr$height, women.metr$weight, main = "", xlab = "Рост (м)", ylab = "Вес (кг)")
grid()
lines(x, y, col="red")
