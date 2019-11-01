import java.util.Arrays;

public class Student {
	String name;
	int [] grades;

	public Student(String name, int [] grades)
	{
		if (!gradesIsValid(grades))
			throw new IllegalArgumentException("Grades is not valid.");

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

	public double getAverageGrade()
	{
		if (this.grades == null)
			return 0.0;

		return Arrays.stream(this.grades).average().getAsDouble();
	}

	public boolean isStraight()
	{
		if (this.grades == null)
			return false;

		for (int g : this.grades)
			if (g != 5)
				return false;

		return true;
	}

	private boolean gradesIsValid(int [] grades)
	{
		for (int g : grades)
			if (g < 2 || g > 5)
				return false;

		return true;
	}
}
