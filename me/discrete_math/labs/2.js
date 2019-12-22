const Reset = "\x1b[0m"
const Bright = "\x1b[1m"
const Dim = "\x1b[2m"
const Underscore = "\x1b[4m"
const Blink = "\x1b[5m"
const Reverse = "\x1b[7m"
const Hidden = "\x1b[8m"

const FgBlack = "\x1b[30m"
const FgRed = "\x1b[31m"
const FgGreen = "\x1b[32m"
const FgYellow = "\x1b[33m"
const FgBlue = "\x1b[34m"
const FgMagenta = "\x1b[35m"
const FgCyan = "\x1b[36m"
const FgWhite = "\x1b[37m"

const BgBlack = "\x1b[40m"
const BgRed = "\x1b[41m"
const BgGreen = "\x1b[42m"
const BgYellow = "\x1b[43m"
const BgBlue = "\x1b[44m"
const BgMagenta = "\x1b[45m"
const BgCyan = "\x1b[46m"
const BgWhite = "\x1b[47m"

class Book {
	constructor(title, author, publicationYear, genre, publisher)
	{
		this.title = title;
		this.author = author;
		this.publicationYear = publicationYear;
		this.genre = genre;
		this.publisher = publisher;
	}

	equalsByGenre(another)
	{
		return this.genre === another.genre;
	}

	equalsByPublicationYear(another)
	{
		return this.publicationYear === another.publicationYear;
	}
}

let books = [
	new Book("Engineering a Compiler", "Keith D. Cooper, Linda Torczon", 2012, "Computer Science", "Elsevier"),
	new Book("Clean Code: A Handbook of Agile Software Craftsmanship", "Robert C. Martin", 2019, "Software Engineering", "Prentice Hall"),
	new Book("The Clean Coder: A Code of Conduct for Professional Programmers", "Robert C. Martin", 2019, "Software Engineering", "Prentice Hall"),
	new Book("Code Complete", "Steve McConnell", 2010, "Software Engineering", "Microsoft Press"),
	new Book("Structure and Interpretation of Computer Programs", "Harold Abelson and Gerald Jay Sussman with Julie Sussman", 2006, "Computer Science", "The MIT Press"),
	new Book("Linear Algebra Done Right", "Sheldon Axler", 2015, "Math", "Springer"),
	new Book("Structured Computer Organization", "Andrew S. Tanenbaum", 2012, "Computer Science", "Pearson"),
	new Book("Лекции по линейной алгебре", "И. М. Гельфанд", 1998, "Math", "МЦНМО"),
	new Book("Dicrete Mathematics An Open Introduction", "Oscar Levin", 2019, "Math", "None"),
	new Book("Линейные и афинные пространства и отображения", "А. В. Ершов", 2016, "Math", "МФТИ")
];

{
	let classes = [];

	Book.prototype.toString = function() {
		return `${this.title}, ${FgBlue}${Bright}${this.genre}${Reset}, ${this.publicationYear}`;
	};

	console.log('{');

	for (let i = 0; i < books.length; ++i) {
		if (classes.includes(books[i].genre))
			continue;

		console.log('\t{\n\t\t' + books[i].toString());

		for (let j = i + 1; j < books.length; ++j)
			if (books[i].equalsByGenre(books[j]))
				console.log('\t\t' + books[j].toString());

		console.log("\t}");

		classes.push(books[i].genre);
	}

	console.log('}');
}

// {
// 	Book.prototype.toString = function() {
// 		return `${this.title}, ${this.genre}, ${FgBlue}${Bright}${this.publicationYear}${Reset}`;
// 	};

// 	let classes = [];

// 	console.log('{');

// 	for (let i = 0; i < books.length; ++i) {
// 		if (classes.includes(books[i].publicationYear))
// 			continue;

// 		console.log('\t{\n\t\t' + books[i].toString());

// 		for (let j = i + 1; j < books.length; ++j)
// 			if (books[i].equalsByPublicationYear(books[j]))
// 				console.log('\t\t' + books[j].toString());

// 		console.log("\t}")

// 		classes.push(books[i].publicationYear);
// 	}

// 	console.log('}');
// }
