public class Main {
	public static void main(String[] args)
	{
		Person a = new Person(null, new FullName("Иван", null, "Чудов"), 180);
		Person b = new Person(a, new FullName("Петр", null, "Чудов"), 175);
		Person c = new Person(b, new FullName("Борис", null, null), 189);

		System.out.println(a);
		System.out.println(b);
		System.out.println(c);
	}
}
