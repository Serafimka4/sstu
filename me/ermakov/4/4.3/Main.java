public class Main {
	public static void main(String[] args)
	{
		House a = new House(2);
		House b = new House(35);
		House c = new House(91);

		// c.floorCount = 12; // error: cannot assign a value to final variable floorCount

		System.out.println(a);
		System.out.println(b);
		System.out.println(c);
	}
}
