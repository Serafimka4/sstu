public class Person {
	final Person father;
	FullName fullName;
	private int height;

	public Person(Person father, FullName fullName, int height)
	{
		setHeight(height);

		this.father = father;
		this.fullName = fullName;

		inheritSurnameAndPatronymicFromFather();
	}

	public Person(Person father, String firstName, int height)
	{
		this(father, new FullName(firstName, null, null), height);
	}

	public Person(String firstName, int height)
	{
		this(null, firstName, height);
	}

	public Person(FullName fullName, int height)
	{
		this(null, fullName, height);
	}

	private void inheritSurnameAndPatronymicFromFather()
	{
		if (this.father != null && this.father.fullName != null) {
			if (this.father.fullName.surname != null)
				this.fullName.surname = father.fullName.surname;

			if (this.father.fullName.name != null)
				this.fullName.patronymic = father.fullName.name + "ович";
		}
	}

	public String toString()
	{
		return String.format("%s, %d", this.fullName, this.height);
	}

	public void setHeight(int h)
	{
		if (h <= 0 || h > 500)
			throw new IllegalArgumentException("Height of a person must be in range [0, 500].");
	}

	public int getHeight()
	{
		return this.height;
	}

	public Person getFather()
	{
		return this.father;
	}

	public FullName getName()
	{
		return this.fullName;
	}

	public String getNameAsString()
	{
		return this.fullName.toString();
	}

	public void setName(FullName f)
	{
		this.fullName = f;
		inheritSurnameAndPatronymicFromFather();
	}
}
