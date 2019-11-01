public class Square {
	Point leftTopCorner;
	double sideLength;

	public Square(Point leftTopCorner, double sideLength)
	{
		this.leftTopCorner = leftTopCorner;
		this.sideLength = sideLength;
	}

	public Square(int x, int y, double sideLength)
	{
		this.leftTopCorner = new Point(x, y);
		this.sideLength = sideLength;
	}

	public String toString()
	{
		return String.format("Квадрат в точке %s со стороной %f", this.leftTopCorner, this.sideLength);
	}

	public Polyline getPolyline()
	{
		return new Polyline(
			new Point(leftTopCorner.x                  , leftTopCorner.y                  ),
			new Point(leftTopCorner.x + this.sideLength, leftTopCorner.y                  ),
			new Point(leftTopCorner.x + this.sideLength, leftTopCorner.y + this.sideLength),
			new Point(leftTopCorner.x                  , leftTopCorner.y + this.sideLength)
		);
	}
}
