public class Album {
	String name;
	Author author;
	Track tracks [];

	public Album(String name, Author author)
	{
		this.name = name;
		this.author = author;
	}

	public String toString()
	{
		return this.name;
	}
}
