public class Main {
	public static void main(String [] args)
	{
		Polyline a = new Polyline(new Point(1, 5), new Point(2, 8), new Point(5, 3));

		System.out.println(a.getLength());

		a.add(new Point(5, 15), new Point(8, 10));

		System.out.println(a.getLength());
	}
}
