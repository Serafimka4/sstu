public class Main {
	public static void main(String[] args)
	{
		Person a = new Person("Лев", 170);
		Person b = new Person(a, new FullName("Сергей", null, "Пушкин"), 168);
		Person c = new Person(b, "Александр", 167);

		System.out.println(a);
		System.out.println(b);
		System.out.println(c);
	}
}
