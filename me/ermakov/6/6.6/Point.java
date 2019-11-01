public class Point {
	int x, y;

	public Point(int x, int y)
	{
		this.x = x;
		this.y = y;
	}

	public Point(Point a)
	{
		this(a.x, a.y);
	}

	public String toString()
	{
		return String.format("(%d, %d)", x, y);
	}
}
