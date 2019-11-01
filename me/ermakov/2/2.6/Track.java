public class Track {
	String name;
	Author author;
	Album album;

	public Track(String name, Author author, Album album)
	{
		this.name = name;
		this.author = author;
		this.album = album;
	}

	public String toString()
	{
		if (this.author == null)
			return String.format("%s, автор: %s", this.name, this.album.author);
		else
			return String.format("%s, авторы: %s, %s", this.name, this.author, this.album.author);
	}
}
