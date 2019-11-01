public class FullName {
	private String name, patronymic, surname;

	public FullName(String name)
	{
		this(name, null, null);
	}

	public FullName(String name, String surname)
	{
		this(name, null, surname);
	}

	public FullName(String name, String patronymic, String surname)
	{
		setName(name);	

		this.patronymic = patronymic;
		this.surname = surname;
	}

	/* Returns full name formatted as "<name> <patronymic> <surname>". If either
	 * name, patronymic or surname is null, it is ommited. For example:
	 *
	 * 		Александр Сергеевич Пушкин
	 * 		Владимир Маяковский
	 * 		Клеопатра
	 */
	public String toString()
	{
		String result = "";

		if (this.name != null)
			result += this.name + " ";

		if (this.patronymic != null)
			result += this.patronymic + " ";

		if (this.surname != null)
			result += this.surname;

		return result.trim();
	}

	private boolean stringIsEmpty(String s)
	{
		return s == null || s.isEmpty();
	}

	public void setName(String n)
	{
		if (stringIsEmpty(n))
			throw new IllegalArgumentException("Name can not be an empty string.");

		this.name = n;
	}

	public String getName()
	{
		return this.name;
	}

	public void setSurname(String s)
	{
		if (stringIsEmpty(s))
			throw new IllegalArgumentException("Surname can not be an empty string.");

		this.surname = s;
	}

	public String getSurname()
	{
		return this.surname;
	}

	public void setPetronymic(String p)
	{
		if (stringIsEmpty(p))
			throw new IllegalArgumentException("Patronymic can not be an empty string.");

		this.patronymic = p;
	}

	public String getPatronymic()
	{
		return this.patronymic;
	}
}
