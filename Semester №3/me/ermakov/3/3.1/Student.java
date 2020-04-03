import java.util.Arrays;

public class Student {
	String name;
	int [] grades;

	public Student(String name, int [] grades)
	{
		this.name = name;
		this.grades = grades;
	}

	public String toString()
	{
		return String.format("%s: %s", this.name, Arrays.toString(this.grades));
	}
}
