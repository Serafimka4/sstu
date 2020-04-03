public class Main {
	public static void main(String[] args)
	{
		Person a = new Person(new FullName("Клеопатра", null, null), 152);
		Person b = new Person(new FullName("Александр", "Сергеевич", "Пушкин"), 167);
		Person c = new Person(new FullName("Владимир", null, "Маяковский"), 189);
	
		System.out.println(a);
		System.out.println(b);
		System.out.println(c);
	}
}
