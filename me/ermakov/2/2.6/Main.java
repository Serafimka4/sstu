public class Main {
	public static void main(String[] args)
	{
		Author author1 = new Author("Металлы");
		Author author2 = new Author("Асид");
		Author author3 = new Author("Бертон");
		Author author4 = new Author("Янг");

		Album album1 = new Album("Кукловод", author1);
		Album album2 = new Album("Шоссе к ООП", author2);

		Track track1 = new Track("Состояние объектов", author4, album2);
		Track track2 = new Track("Шоссе к ООП", null, album2);
		Track track3 = new Track("Одноразовый программист", author3, album1);

		System.out.println(track1);
		System.out.println(track2);
		System.out.println(track3);
	}
}
