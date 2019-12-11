class Book {
	constructor(title, author, publicationYear, genre, publisher)
	{
		this.title = title;
		this.author = author;
		this.publicationYear = publicationYear;
		this.genre = genre;
		this.publisher = publisher;
	}

	static equalsByGenre(self, another)
	{
		return self.genre === another.genre;
	}

	static equalsByPublicationYear(self, another)
	{
		return self.publicationYear === another.publicationYear;
	}
}

const books = [
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

function splitIntoEquivalenceClasses(set, isEquivalient)
{
	const alreadyInsideSomeClass = function(clasess, element) {
		for (let c of clasess)
			if (c.length > 0)
				if (isEquivalient(element, c[0]))
					return true;

		return false;
	};

	let clasess = [];

	for (let i = 0; i < set.length; ++i) {
		if (alreadyInsideSomeClass(clasess, set[i]))
			continue;

		let newClass = [
			set[i]
		];

		for (let j = i + 1; j < set.length; ++j)
			if (isEquivalient(set[i], set[j]))
				newClass.push(set[j]);

		clasess.push(newClass);
	}

	return clasess;
}

console.log(splitIntoEquivalenceClasses(books, Book.equalsByPublicationYear));
