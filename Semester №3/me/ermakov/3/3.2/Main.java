public class Main {
	public static void main(String[] args)
	{
		Gradebook a = new Gradebook(171896, "Вася", new GradebookEntry [] {
			new GradebookEntry("Информатика", "Ермаков", 5),
			new GradebookEntry("Математика", "Петрова", 4),
			new GradebookEntry("Физика", "Сидоров", 5)
		});

		a.entries[2] = new GradebookEntry("Английский язык", "Буров", 4);

		Gradebook b = new Gradebook(173654, "Петя", new GradebookEntry [] {
			new GradebookEntry(a.entries[0]),
			new GradebookEntry(a.entries[1]),
			new GradebookEntry(a.entries[2])
		});

		b.entries[1].grade = 5;

		System.out.println(a);
		System.out.println(b);
	}
}
