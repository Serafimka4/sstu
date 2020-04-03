public class Main {
	public static void main(String[] args)
	{
		Gun g = new Gun(7);

		g.reload(3);

		g.shoot();
		g.shoot();
		g.shoot();
		g.shoot();
		g.shoot();

		g.reload(8);

		g.shoot();
		g.shoot();

		g.discharge();

		g.shoot();
	}
}
