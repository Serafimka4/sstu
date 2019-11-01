public class Worker {
	String name;
	Department department;

	public Worker(String name, Department department)
	{
		this.name = name;
		this.department = department;
	}

	public String toString()
	{
		if (this != this.department.boss)
			return String.format("%s работает в отделе %s, начальник которого %s", name, department.name, department.boss.name);
		else
			return String.format("%s начальник отделе %s", name, department.name);
	}
}
