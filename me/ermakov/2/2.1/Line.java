public class Line {
	Point begin, end;

	public Line(Point b, Point e)
	{
		begin = b;
		end = e;
	}

	public String toString()
	{
		return String.format("Линия от %s до %s", begin, end);
	}
}
