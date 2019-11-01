import java.util.ArrayList;
import java.util.Arrays;

public class Polyline {
	ArrayList<Point> points;

	public Polyline()
	{
		this.points = new ArrayList<Point>();
	}

	public Polyline(Point... points)
	{
		this.points = new ArrayList<Point>(Arrays.asList(points));
	}

	public void add(Point... points)
	{
		for (Point p : points)
			this.points.add(p);
	}

	public String toString()
	{
		String ret = String.format("Линия [");

		for (int i = 0; i < this.points.size() - 1; ++i)
			ret += this.points.get(i) + ", ";

		ret += this.points.get(this.points.size() - 1);

		ret += "]";

		return ret;
	}

	private double lengthOfLine(Point begin, Point end)
	{
		return Math.sqrt((end.x - begin.x) * (end.x - begin.x) + (end.y - begin.y) * (end.y - begin.y));
	}

	public double getLength()
	{
		double ret = 0.0;

		for (int i = 1; i < this.points.size(); ++i) {
			Point begin = this.points.get(i - 1);
			Point end = this.points.get(i);

			ret += lengthOfLine(begin, end);
		}

		return ret;
	}

	public Point getLastPoint()
	{
		return this.points.get(this.points.size() - 1);
	}
}
