public class Person {
	String name;
	int height;

	public Person(String _n, int _h)
	{
		name = _n;
		height = _h;
	}

	public String toString()
	{
		if (height > 185)
			return String.format("%s большой человек", name);
		else if (height < 160)
			return String.format("%s маленький человек", name);
		else
			return String.format("%s обычный человек", name);
	}
}
