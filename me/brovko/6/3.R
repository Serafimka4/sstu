#
# 1. Загрузите данные из файла в датафрейм HousePrice, используя
#    функцию read.table.
#

HousePrice <- read.table("houses.data")

#
# 2. Загрузите данные из файла в датафрейм HousePrice1,
#    используя функцию read.table. Загрузку следует выполнить
#    так, чтобы первая строка воспринималась как заголовки столбцов,
#    а не как текстовые данные.
#

HousePrice1 <- read.table("houses1.data", header = TRUE)

#
# 3. Выполните команду HP <- edit(HousePrice), записав в
#    переменную HP отредактированные данные (измените несколько
#    значений в открывшемся окне редактора).
#

HP <- edit(HousePrice)

#
# 4. Сохраните фрейм HP в файл “myframe.txt”, используя функцию
#    write.table. Сохранение следует выполнить так, чтобы содержимое
#    файла имело тот же формат, что и файл  “houses1.data”, то есть
#    без номеров строк и без кавычек у текстовых данных.
#

write.table(HP, file = "myframe.txt", row.names = FALSE, quote = FALSE)

#
# 5. Выведите на консоль содержимое столбца Rooms у датафреймов HousePrice,
#    HousePrice1, HP. Подсказка: используйте функции attach() и detach().
#

print(HousePrice$Rooms)
print(HousePrice1$Rooms)
print(HP$Rooms)
