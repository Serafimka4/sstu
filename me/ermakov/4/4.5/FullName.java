public class FullName {
	String name, patronymic, surname;

	public FullName(String name)
	{
		this.name = name;
		this.patronymic = null;
		this.surname = null;
	}

	public FullName(String name, String surname)
	{
		this.name = name;
		this.patronymic = null;
		this.surname = surname;
	}

	public FullName(String name, String patronymic, String surname)
	{
		this.name = name;
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
}
