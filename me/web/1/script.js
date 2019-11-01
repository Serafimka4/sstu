"use strict";

class Film {
	constructor(title, year, country)
	{
		this.title = title;
		this.year = year;
		this.country = country;
	}
}

const films = [
	new Film("Криминальное чтиво", "2014", "USA"),
	new Film("Мстители", "2014", "USA"),
	new Film("Железный человек", "2014", "USA"),
	new Film("Халк", "2016", "USA"),
	new Film("Тихоокеанский рубеж", "2015", "USA"),
	new Film("Звездные войны", "2015", "USA"),
	new Film("Шерлок Холмс", "2014", "Englang"),
	new Film("Мистер Бин", "2016", "England"),
	new Film("Джокер", "2016", "Russia"),
	new Film("Бэтмен", "2015", "Russia")
];

let year = "2014";
let country = "USA";
let resultList = document.getElementById("Result");

function SelectYear(y)
{
	year = y;
}

function SelectCountry(c)
{
	country = c;
}

function FilterFilms()
{
	resultList.innerHTML = "";

	for (const f of films)
		if (f.year === year && f.country === country)
			resultList.innerHTML += `<li>${f.title}</li>`;
}

function ResetStyles(elements)
{
	for (let e of elements)
		e.className = "";
}

const yearInputs = [
	document.querySelector("li[name='2014']"),
	document.querySelector("li[name='2015']"),
	document.querySelector("li[name='2016']")
];

const countryInputs = [
	document.querySelector("li[name='Russia']"),
	document.querySelector("li[name='USA']"),
	document.querySelector("li[name='England']")
];

for (let y of yearInputs) {
	y.addEventListener('click', function () {
		ResetStyles(yearInputs);
		this.className += "active";

		SelectYear(this.attributes.name.nodeValue);
		FilterFilms();
	});
}

for (let c of countryInputs) {
	c.addEventListener('click', function () {
		ResetStyles(countryInputs);
		this.className += "active";

		SelectCountry(this.attributes.name.nodeValue);
		FilterFilms();
	});
}

FilterFilms();
