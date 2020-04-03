public class Person {
	FullName fullName;
	int height;

	public Person(FullName _n, int _h)
	{
		fullName = _n;
		height = _h;
	}

	public String toString()
	{
		if (height > 185)
			return String.format("%s большой человек", fullName);
		else if (height < 160)
			return String.format("%s маленький человек", fullName);
		else
			return String.format("%s обычный человек", fullName);
	}
}
