"use strict";

class Book {
	constructor(title, genre, country)
	{
		this.title = title;
		this.genre = genre;
		this.country = country;
	}
}

const books = [
	new Book("Моби Дик", "biography", "USA"),
	new Book("Шерлок Холмс", "criminal", "USA"),
	new Book("Братья Карамазовы", "biography", "Russia"),
	new Book("Война и Мир", "fantasy", "Russia"),
	new Book("Алые паруса", "fantasy", "Russia"),
	new Book("Записки юного врача", "biography", "Russia"),
	new Book("Бедная Лиза", "fantasy", "USA"),
	new Book("Лолита", "criminal", "USA"),
	new Book("Дракула", "criminal", "Russia"),
	new Book("Слон и моська", "fantasy", "USA")
];

let genre = "fantasy";
let country = "USA";
let resultList = document.getElementById("Result");

function SelectGenre(y)
{
	genre = y;
}

function SelectCountry(c)
{
	country = c;
}

function FilterBooks()
{
	resultList.innerHTML = "";

	for (let i = 0; i < books.length - 1; ++i)
		if (books[i].genre === genre && books[i].country === country)
			resultList.innerHTML += `${books[i].title}, `;

	if (books[books.length - 1].genre === genre && books[books.length - 1].country === country)
			resultList.innerHTML += `${books[books.length - 1].title}.`;
}

function ResetStyles(elements)
{
	for (let e of elements)
		e.className = "";
}

const genreInputs = [
	document.getElementById('biography'),
	document.getElementById('fantasy'),
	document.getElementById('criminal')
];

const countryInputs = [
	document.getElementById('Russia'),
	document.getElementById('USA')
];

for (let y of genreInputs) {
	y.addEventListener('click', function () {
		ResetStyles(genreInputs);
		this.className += "active";

		SelectGenre(this.attributes.id.nodeValue);
		FilterBooks();
	});
}

for (let c of countryInputs) {
	c.addEventListener('click', function () {
		ResetStyles(countryInputs);
		this.className += "active";

		SelectCountry(this.attributes.id.nodeValue);
		FilterBooks();
	});
}

FilterBooks();

