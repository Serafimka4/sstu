public class Person {
	Person father;
	FullName fullName;
	int height;

	public Person(Person _f, FullName _n, int _h)
	{
		father = _f;
		fullName = _n;
		height = _h;

		if (father == null)
			return;

		if (fullName.surname == null)
			if (father.fullName.surname != null)
				fullName.surname = father.fullName.surname;

		if (fullName.patronymic == null)
			if (father.fullName.name != null)
				fullName.patronymic = father.fullName.name + "ович";
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
