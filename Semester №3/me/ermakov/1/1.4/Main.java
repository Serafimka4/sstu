public class Main {
	public static void main(String[] args)
	{
		FullName a = new FullName("Клеопатра", null, null);
		FullName b = new FullName("Александр", "Сергеевич", "Пушкин");
		FullName c = new FullName("Владимир", null, "Маяковский");

		System.out.println(a);
		System.out.println(b);
		System.out.println(c);
	}
}
