public class Main {
	public static void main(String[] args)
	{
		Student a = new Student("Вася", new int [] {3, 4, 5});
		Student b = new Student("Максим", null);

		System.out.println(a);
		System.out.println(b);
	}
}
