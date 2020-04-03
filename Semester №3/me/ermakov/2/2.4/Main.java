public class Main {
	public static void main(String[] args)
	{
		Department d = new Department("IT");

		Worker a = new Worker("Петров", d);
		Worker b = new Worker("Козлов", d);
		Worker c = new Worker("Сидоров", d);
	
		d.boss = b;

		System.out.println(a);
		System.out.println(b);
		System.out.println(c);
	}
}
