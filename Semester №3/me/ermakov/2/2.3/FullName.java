public class FullName {
	String name, patronymic, surname;

	public FullName(String _n, String _p, String _s)
	{
		name = _n;
		patronymic = _p;
		surname = _s;
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

		if (name != null)
			result += name + " ";

		if (patronymic != null)
			result += patronymic + " ";

		if (surname != null)
			result += surname;

		return result.trim();
	}
}
