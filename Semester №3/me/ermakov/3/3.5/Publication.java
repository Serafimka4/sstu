public class Publication {
	String title;
	String text;
	String [] tags;
	Comment [] comments;
	int rating;

	public Publication(String title, String text, String [] tags, Comment [] comments, int rating)
	{
		this.title = title;
		this.text = text;
		this.tags = tags;
		this.comments = comments;
		this.rating = rating;
	}

	public String toString()
	{
		String result = String.format("(%d) %s\n\nтеги: ", this.rating, this.title);

		for (String t : this.tags)
			result += t + ", ";

		/* Remove ", " at the end of the string. */
		result = Main.removeLastChar(result);
		result = Main.removeLastChar(result);

		result += "\n\n" + this.text + "\n\nКомментарии:\n\n" + Comment.commentsTreeToString(this.comments);

		return result;
	}
}
