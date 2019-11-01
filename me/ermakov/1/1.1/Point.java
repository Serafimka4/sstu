public class Point {
	int x, y;

	public Point(int _x, int _y)
	{
		x = _x;
		y = _y;
	}

	public String toString()
	{
		return String.format("(%d, %d)", x, y);
	}
}
