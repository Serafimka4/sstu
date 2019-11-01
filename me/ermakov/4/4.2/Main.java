public class Main {
	public static void main(String[] args)
	{
		Line a = new Line(1, 3, 23, 8);
		Line b = new Line(5, 10, 25, 10);
		Line c = new Line(a.begin, b.end);

		System.out.println(a);
		System.out.println(b);
		System.out.println(c);
	}
}
