public class Line {
	Point begin, end;

	public Line(Point b, Point e)
	{
		begin = b;
		end = e;
	}

	public Line(int x1, int y1, int x2, int y2)
	{
		begin = new Point(x1, y1);
		end = new Point(x2, y2);
	}

	public double getLength()
	{
		return Math.sqrt((this.end.x - this.begin.x) * (this.end.x - this.begin.x) + (this.end.y - this.begin.y) * (this.end.y - this.begin.y));
	}

	public String toString()
	{
		return String.format("Линия от %s до %s", begin, end);
	}
}
