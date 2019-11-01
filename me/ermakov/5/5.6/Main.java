public class Main {
	public static void main(String[] args)
	{
		Student a = new Student("Вася", new int [] {3, 4, 5, 4});
		Student b = new Student("Петя", new int [] {5, 5, 5, 5});

		System.out.println(a.getAverageGrade());
		System.out.println(b.getAverageGrade());

		System.out.println(a.isStraight());
		System.out.println(b.isStraight());
	}
}

