public class Comment {
	Comment [] childComments;
	String text;
	int rating;

	public Comment(String text, int rating, Comment childComments [])
	{
		this.text = text;
		this.rating = rating;
		this.childComments = childComments;
	}

	public String toString()
	{
		return String.format("(%d) %s", rating, text);
	}

	public static String commentsTreeToString(Comment [] firstLevelComments)
	{
		String result = new String();

		result = commentsTreeToStringInner(result, firstLevelComments, "");

		return result;
	}

	private static String commentsTreeToStringInner(String outputBuffer, Comment [] firstLevelComments, String indentation)
	{
		for (Comment c : firstLevelComments) {
			outputBuffer += indentation + c + "\n";

			if (c.childComments != null)
				outputBuffer = commentsTreeToStringInner(outputBuffer, c.childComments, indentation + "    ");
		}

		return outputBuffer;
	}
}
