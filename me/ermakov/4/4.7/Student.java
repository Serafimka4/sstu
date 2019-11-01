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
		if (this.grades != null)
			return String.format("%s: %s", this.name, Arrays.toString(this.grades));
		else
			return String.format("%s", this.name);
	}
}
