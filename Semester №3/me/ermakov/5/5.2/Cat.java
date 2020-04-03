public class Cat {
	String name;

	public Cat(String name)
	{
		this.name = name;
	}

	public void meow()
	{
		System.out.println(this.name + ": мяу!");
	}

	public void meow(int n)
	{
		System.out.print(this.name + ": ");

		while (n-- != 1)
			System.out.print("мяу-");

		System.out.println("мяу!");
	}
}
