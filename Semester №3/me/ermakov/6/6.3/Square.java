public class Square {
	Point leftTopCorner;
	private double sideLength;

	public Square(Point leftTopCorner, double sideLength)
	{
		setSideLength(sideLength);

		this.leftTopCorner = leftTopCorner;
		this.sideLength = sideLength;
	}

	public Square(int x, int y, double sideLength)
	{
		setSideLength(sideLength);		
		this.leftTopCorner = new Point(x, y);
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

	public void setSideLength(double s)
	{
		if (s <= 0)
			throw new IllegalArgumentException("Side length of a square can not be neither zero or negative.");

		this.sideLength = s;
	}

	public double getSideLength()
	{
		return this.sideLength;
	}
}
