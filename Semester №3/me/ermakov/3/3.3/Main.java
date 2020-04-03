public class Main {
	public static void main(String[] args)
	{
		City a = new City("A");
		City b = new City("B");
		City c = new City("C");
		City d = new City("D");
		City e = new City("E");
		City f = new City("F");

		a.pathToCities = new PathToCity [] {
			new PathToCity(b, 5),
			new PathToCity(d, 6),
			new PathToCity(f, 1)
		};

		b.pathToCities = new PathToCity [] {
			new PathToCity(a, 5),
			new PathToCity(c, 3)
		};

		c.pathToCities = new PathToCity [] {
			new PathToCity(b, 3),
			new PathToCity(d, 4)
		};

		d.pathToCities = new PathToCity [] {
			new PathToCity(a, 6),
			new PathToCity(c, 4),
			new PathToCity(e, 2)
		};

		e.pathToCities = new PathToCity [] {
			new PathToCity(f, 2)
		};

		f.pathToCities = new PathToCity [] {
			new PathToCity(b, 1),
			new PathToCity(e, 2)
		};

		System.out.println(a);
		System.out.println(b);
		System.out.println(c);
		System.out.println(d);
		System.out.println(e);
		System.out.println(f);
	}
}
