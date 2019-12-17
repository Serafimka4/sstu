dollar <- read.table('data/dollar.txt')[,3]
dollar <- ts(dollar, start = c(06, 01), frequency = 30.5)
oldpar <- par(mfrow=c(2,1))

par(oldpar)

dol <- read.table('data/dol.txt')[,3]
oldpar <- par(mfrow=c(2,1))
dollar <- ts(dol, start = c(06, 01), frequency = 30.5)

oldpar <- par(mfrow=c(2,1))

model01 <- arima(dollar, order=c(0,0,1))
model02 <- arima(dollar, order=c(0,0,2))
model03 <- arima(dollar, order=c(0,0,3))
model04 <- arima(dollar, order=c(0,0,4))
model05 <- arima(dollar, order=c(0,0,5))
model06 <- arima(dollar, order=c(0,0,6))
model07 <- arima(dollar, order=c(0,0,7))
model08 <- arima(dollar, order=c(0,0,8))
model09 <- arima(dollar, order=c(0,0,9))
model010 <- arima(dollar, order=c(0,0,10))
model011 <- arima(dollar, order=c(0,0,11))
model012 <- arima(dollar, order=c(0,0,12))
model013 <- arima(dollar, order=c(0,0,13))
model014 <- arima(dollar, order=c(0,0,14))

plot(AIC(model01, model02, model03, model04, model05, model06, model07, model08, model09, model010, model011, model012, model013, model014), type="b")

model07  <-  arima(dollar,  order=c(0,0,7))
model107  <-  arima(dollar,  order=c(1,0,7))
model207  <-  arima(dollar,  order=c(2,0,7))
model307  <-  arima(dollar,  order=c(3,0,7))
model407  <-  arima(dollar,  order=c(4,0,7))

AIC(model07,  model107,   model207,   model307,   model407)

model2070   <-   arima(dollar,   order=c(2,0,7))
model2071   <-   arima(dollar,   order=c(2,1,7))
model2072   <-   arima(dollar,   order=c(2,2,7))
model2073   <-   arima(dollar,   order=c(2,3,7))
model2074   <-   arima(dollar,   order=c(2,4,7))
model2075   <-   arima(dollar,   order=c(2,5,7))
model2076   <-   arima(dollar,   order=c(2,6,7))

AIC(model2070, model2071, model2072, model2073, model2074, model2075)

max(dollar)

max(dollar)
min(dollar)

lines(predict(model2070, n.ahead=12, se.fit = TRUE)$pred, col="green")
lines(predict(model2070, n.ahead=12, se.fit = TRUE)$sepredict(model2123, n.ahead=12, se.fit = TRUE)$pred, col="red")
lines(predict(model2070, n.ahead=12, se.fit = TRUE)$sepredict(model2070, n.ahead=12, se.fit = TRUE)$pred, col="red")
lines(predict(model2070, n.ahead=12, se.fit = TRUE)$se + predict(model2070, n.ahead=12, se.fit = TRUE)$pred, col="red")
lines(-predict(model2070, n.ahead=12, se.fit = TRUE)$se + predict(model2070, n.ahead=12, se.fit = TRUE)$pred, col="red")

lines(predict(model2070, n.ahead=12, se.fit = TRUE)$sepredict(model2123, n.ahead=12, se.fit = TRUE)$pred, col="red")
lines(predict(model2070, n.ahead=12, se.fit = TRUE)$pred, col="green")
lines(predict(model2070, n.ahead=12, se.fit = TRUE)$sepredict(model2123, n.ahead=12, se.fit = TRUE)$pred, col="red")
lines(-predict(model2070, n.ahead=12, se.fit = TRUE)$se + predict(model2070, n.ahead=12, se.fit = TRUE)$pred, col="red")
lines(predict(model2070, n.ahead=12, se.fit = TRUE)$se + predict(model2070, n.ahead=12, se.fit = TRUE)$pred, col="red")

full_doll <- read.table('data/dollar.txt')[,3]
full_doll <- read.table('data/dollar.txt')[,3]
full_doll <- ts(full_doll, start=c(06.01), frequency=30,5)
f_dollar <- read.table('data/dollar.txt')[,3]
full_dollar <- ts(f_dollar, start = c(06, 01), frequency = 30.5)

plot(full_dollar, xlim=c(06.01,08.10), ylim=c(27.6,28.4))

lines(predict(model2070, n.ahead=12, se.fit = TRUE)$pred, col="green")
lines(predict(model2070, n.ahead=12, se.fit = TRUE)$sepredict(model2123, n.ahead=12, se.fit = TRUE)$pred, col="red")
lines(predict(model2070, n.ahead=12, se.fit = TRUE)$sepredict(model2070, n.ahead=12, se.fit = TRUE)$pred, col="red")
lines(predict(model2070, n.ahead=12, se.fit = TRUE)$se + predict(model2070, n.ahead=12, se.fit = TRUE)$pred, col="red")
lines(-predict(model2070, n.ahead=12, se.fit = TRUE)$se + predict(model2070, n.ahead=12, se.fit = TRUE)$pred, col="red")
