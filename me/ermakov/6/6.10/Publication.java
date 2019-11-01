public class Publication {
	final private String title;
	private String text;
	final private String [] tags;
	Comment [] comments;
	private int rating;
	private boolean isEditable;

	public Publication(String title, String text, String [] tags, Comment [] comments, int rating)
	{
		this.title = title;
		this.text = text;
		this.tags = tags;
		this.comments = comments;
		this.rating = rating;
		this.isEditable = this.comments == null;
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

	public String getTitle()
	{
		return title;
	}

	public boolean isEditable()
	{
		return isEditable;
	}

	public void incrementRating()
	{
		this.rating++;
		this.isEditable = false;
	}

	public void decrementRating()
	{
		this.rating--;
		this.isEditable = false;
	}

	public void setText(String t)
	{
		if (!isEditable())
			throw new UnsupportedOperationException("Can not modify publication's text: the publication is not editable.");

		this.text = t;
	}

	public String getText()
	{
		return this.text;
	}
}
