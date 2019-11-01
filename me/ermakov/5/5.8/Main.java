public class Main {
	public static void main(String [] args)
	{
		Square a = new Square(5, 3, 23);
		Polyline b = a.getPolyline();

		System.out.println(b.getLength());

		b.getLastPoint().x = 15;
		b.getLastPoint().y = 25;

		System.out.println(b.getLength());
	}
}
