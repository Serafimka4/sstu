public class Main {
	public static void main(String[] args)
	{
		/* 1 */
		Student a = new Student("Вася", new int [] {3, 4, 5});
		
		/* 2 */
		Student b = new Student("Петя", a.grades);

		/* 3 */

		b.grades[0] = 5;

		System.out.println(a);
		System.out.println(b);

		/* 4 */

		Student c = new Student("Андрей", a.grades.clone());

		a.grades[0] = 3;

		System.out.println(a);
		System.out.println(c);
	}
}
