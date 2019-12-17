polzovateli <- ts(read.table("data/data.txt")$V3, start=c(2004,12), frequency=12)

cum.polzovateli <- ts(cumsum(polzovateli), start=c(2004,12), frequency=12)

oldpar <- par(mfrow=c(2,1))
plot(polzovateli, type="b", log="y", xlab="")
par(oldpar)

model01 <- arima(cum.polzovateli, order=c(0,0,1))
model02 <- arima(cum.polzovateli, order=c(0,0,2))
model03 <- arima(cum.polzovateli, order=c(0,0,3))
model04 <- arima(cum.polzovateli, order=c(0,0,4))
model05 <- arima(cum.polzovateli, order=c(0,0,5))
model06 <- arima(cum.polzovateli, order=c(0,0,6))
model07 <- arima(cum.polzovateli, order=c(0,0,7))
model08 <- arima(cum.polzovateli, order=c(0,0,8))
model09 <- arima(cum.polzovateli, order=c(0,0,9))
model010 <- arima(cum.polzovateli, order=c(0,0,10))
model011 <- arima(cum.polzovateli, order=c(0,0,11))
model012 <- arima(cum.polzovateli, order=c(0,0,12))
model013 <- arima(cum.polzovateli, order=c(0,0,13))
model014 <- arima(cum.polzovateli, order=c(0,0,14))

plot(AIC(model01, model02, model03, model04, model05, model06, model07, model08, model09, model010, model011, model012, model013, model014), type="b")

model012 <- arima(cum.polzovateli, order=c(0,0,12))
model112 <- arima(cum.polzovateli, order=c(1,0,12))
model212 <- arima(cum.polzovateli, order=c(2,0,12))
model312 <- arima(cum.polzovateli, order=c(3,0,12))
model412 <- arima(cum.polzovateli, order=c(4,0,12))

AIC(model012, model112, model212, model312, model412)

model2120 <- arima(cum.polzovateli, order=c(2,0,12))
model2121 <- arima(cum.polzovateli, order=c(2,1,12))
model2122 <- arima(cum.polzovateli, order=c(2,2,12))
model2123 <- arima(cum.polzovateli, order=c(2,3,12))
model2124 <- arima(cum.polzovateli, order=c(2,4,12))
model2125 <- arima(cum.polzovateli, order=c(2,5,12))
AIC(model2120, model2121 ,model2122, model2123, model2124)

plot(cum.polzovateli, xlim=c(2004.7,2010), ylim=c(0,6500))
lines(predict(model2123, n.ahead=12, se.fit = TRUE)$pred, col="green")
lines(predict(model2123, n.ahead=12, se.fit = TRUE)$se + predict(model2123, n.ahead=12, se.fit = TRUE)$pred, col="red")
lines(-predict(model2123, n.ahead=12, se.fit = TRUE)$se + predict(model2123, n.ahead=12, se.fit = TRUE)$pred, col="red")

round(predict(model2123, n.ahead=12, se.fit = TRUE)$se + predict(model2123, n.ahead=12, se.fit = TRUE)$pred)

round(-predict(model2123, n.ahead=12, se.fit = TRUE)$se + predict(model2123, n.ahead=12, se.fit = TRUE)$pred)