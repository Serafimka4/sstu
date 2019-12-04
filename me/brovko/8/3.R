prp.coast <- read.table("data/primula.txt", as.is  = TRUE, h = TRUE)

plot(yfrac ~ nwse, data = prp.coast, type = "n", xlab = "Дистанция от Новороссийска, км.", ylab = "Пропорция светлых цветков")

rect(129, -10, 189, 110, col = gray(0.8), border = NA)
box()

mtext("129", at = 128, side = 3, line = 0, cex = 0.8)
mtext("189", at = 189, side = 3, line = 0, cex = 0.8)

points(yfrac ~ nwse, data = prp.coast)
abline(lm(yfrac ~ nwse, data = prp.coast), lty = 2)
lines(loess.smooth(prp.coast$nwse, prp.coast$yfrac), lty = 1)