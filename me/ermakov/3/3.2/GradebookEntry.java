public class GradebookEntry {
	String subjectName;
	String teacherName;
	int grade;

	public GradebookEntry(String subjectName, String teacherName, int grade)
	{
		this.subjectName = subjectName;
		this.teacherName = teacherName;
		this.grade = grade;
	}

	public GradebookEntry(GradebookEntry ge)
	{
		this(new String(ge.subjectName), new String(ge.teacherName), ge.grade);
	}

	public String toString()
	{
		return String.format("%s, %s, %d", this.subjectName, this.teacherName, this.grade);
	}
}
