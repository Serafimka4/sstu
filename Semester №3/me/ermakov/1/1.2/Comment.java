public class Comment {
	String text;
	int rating;

	public Comment(String _t, int _r)
	{
		text = _t;
		rating = _r;
	}

	public String toString()
	{
		return String.format("(%d) %s", rating, text);
	}
}
