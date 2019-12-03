using System;
using System.Text;
using System.Xml;

class Program {
    const String filename = "Inventory.xml";
    static XmlDocument document;

    static void Main(string[] args) {
        document = new XmlDocument();
        document.Load(filename);

        bool appShouldClose = false;

        while (!appShouldClose) {
            DisplayMenu();

            ConsoleKeyInfo key = Console.ReadKey();

            if (key.KeyChar == '1')
                DisplayAllBooks();
            else if (key.KeyChar == '2')
                AddNewBook();
            else if (key.KeyChar == '3')
                DeleteBook();
            else if (key.KeyChar == '4')
                ChangeBook();
            else if (key.KeyChar == '5')
                appShouldClose = true;
        }
    }

    static void DisplayMenu() {
        Console.WriteLine("[1] Display all the books");
        Console.WriteLine("[2] Add new book");
        Console.WriteLine("[3] Delete book");
        Console.WriteLine("[4] Change book");
        Console.WriteLine("[5] Exit");
    }

    static void DisplayAllBooks() {
        foreach (XmlNode n in document.DocumentElement) {
            Console.Write("\n");

            Console.WriteLine("Title: "   + n.ChildNodes.Item(0).InnerText);
            Console.WriteLine("Author: "  + n.ChildNodes.Item(1).InnerText);
            Console.WriteLine("Binding: " + n.ChildNodes.Item(2).InnerText);
            Console.WriteLine("Pages: "   + n.ChildNodes.Item(3).InnerText);
            Console.WriteLine("Price: "   + n.ChildNodes.Item(4).InnerText);
        }
    }

    static void AddNewBook() {
        Console.Write("Title: ");
        String title = Console.ReadLine();

        Console.Write("Author: ");
        String author = Console.ReadLine();

        Console.Write("Binding: ");
        String binding = Console.ReadLine();

        Console.Write("Pages: ");
        String pages = Console.ReadLine();

        Console.Write("Price: ");
        String price = Console.ReadLine();

        CreateBook(title, author, binding, pages, price);
    }

    static void DeleteBook() {
        Console.Write("\nThe title of a book to delete: ");
        DeleteBookByTitle(Console.ReadLine());
    }

    static void ChangeBook() {
        Console.Write("\nThe title of the book to change: ");
        String title = Console.ReadLine();
        
        Console.Write("The tag name: ");
        String tag = Console.ReadLine();
        
        Console.Write("New value: ");
        String newValue = Console.ReadLine();
        
        ChangeTagInsideBook(title, tag, newValue);
    }

    static void CreateBook(String title, String author, String binding, String pages, String price) {
        XmlElement tagBook = document.CreateElement("BOOK");
        XmlElement tagTitle = document.CreateElement("TITLE");
        XmlElement tagAuthor = document.CreateElement("AUTHOR");
        XmlElement tagBinding = document.CreateElement("BINDING");
        XmlElement tagPages = document.CreateElement("PAGES");
        XmlElement tagPrice = document.CreateElement("PRICE");

        tagTitle.InnerText = title;
        tagAuthor.InnerText = author;
        tagBinding.InnerText = binding;
        tagPages.InnerText = pages;
        tagPrice.InnerText = price;

        tagBook.AppendChild(tagTitle);
        tagBook.AppendChild(tagAuthor);
        tagBook.AppendChild(tagBinding);
        tagBook.AppendChild(tagPages);
        tagBook.AppendChild(tagPrice);

        document.DocumentElement.AppendChild(tagBook);
        document.Save(filename);
    }

    static void DeleteBookByTitle(String title) {
        XmlElement root = document.DocumentElement;

        for (int i = 0; i < root.ChildNodes.Count; ++i)
            if (root.ChildNodes.Item(i).ChildNodes.Item(0).InnerText == title)
                root.RemoveChild(root.ChildNodes.Item(i));

        document.Save(filename);
    }

    static void ChangeTagInsideBook(String title, String tag, String newValue) {
        foreach (XmlNode books in document.DocumentElement)
            if (books.ChildNodes.Item(0).InnerText == title)
                foreach (XmlNode node in books.ChildNodes)
                    if (node.Name == tag)
                        node.InnerText = newValue;

        document.Save(filename);
    }
}
