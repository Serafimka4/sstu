public class Main {
	public static void main(String[] args)
	{
		FullName a = new FullName("Клеопатра");
		FullName b = new FullName("Александр", "Сергеевич", "Пушкин");
		FullName c = new FullName("Владимир", "Маяковский");
		FullName d = new FullName("Христофор", "Бонифатьевич", null);

		System.out.println(a);
		System.out.println(b);
		System.out.println(c);
		System.out.println(d);
	}
}
