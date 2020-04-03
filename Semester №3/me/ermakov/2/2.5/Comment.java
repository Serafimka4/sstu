public class Comment {
	Comment childComment;
	String text;
	int rating;

	public Comment(String text, int rating, Comment childComment)
	{
		this.text = text;
		this.rating = rating;
		this.childComment = childComment;
	}

	public String toString()
	{
		return String.format("(%d) %s", rating, text);
	}
}
