public class Gradebook {
	long id;
	String studentName;
	GradebookEntry [] entries;

	public Gradebook(long id, String studentName, GradebookEntry [] entries)
	{
		this.id = id;
		this.studentName = studentName;
		this.entries = entries;
	}

	public String toString()
	{
		String result = String.format("%s, %d\n", studentName, id);

		for (GradebookEntry e : entries)
			result += "\t" + e + "\n";

		return result;
	}
}
