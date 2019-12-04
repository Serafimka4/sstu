# Загружаем и проверяем данные:

vybory <- read.table("data/vybory.txt", h = TRUE)
str(vybory)
head(vybory)

# Теперь присоединим таблицу данных, для того чтобы с ее колонками
# можно было работать как с независимыми переменными:

attach(vybory)

# Вычислим доли проголосовавших за каждого кандидата и явку:

DOLJA <- cbind(KAND.1, KAND.2, KAND.3) / IZBIR
JAVKA <- (DEJSTV + NEDEJSTV) / IZBIR

# Посмотрим, есть ли корреляция:

cor(JAVKA, DOLJA)

# Корреляция есть, хотя и невысокая для первых двух кандидатов.
# Похоже, что голосование по третьему кандидату серьезно отличалось.
# Проверим это:

lm.1 <- lm(KAND.1/IZBIR ~ JAVKA)
lm.2 <- lm(KAND.2/IZBIR ~ JAVKA)
lm.3 <- lm(KAND.3/IZBIR ~ JAVKA)

lapply(list(lm.1, lm.2, lm.3), summary)

# Коэффициенты регрессии у третьего кандидата сильно отличаются.
# Да и R^2 гораздо выше. Посмотрим, как это выглядит графически:

plot(KAND.3/IZBIR ~ JAVKA, xlim = c(0,1), ylim = c(0,1), xlab = "Явка", ylab = "Доля проголосовавших за кандидата")

points(KAND.1/IZBIR ~ JAVKA, pch = 2)
points(KAND.2/IZBIR ~ JAVKA, pch = 3)

abline(lm.3)
abline(lm.2, lty = 2)
abline(lm.1, lty = 3)

legend("topleft", lty = c(3, 2, 1), legend = c("Кандидат 1", "Кандидат 2", "Кандидат 3"))

detach(vybory)
