public class Main {
	public static void main(String[] args)
	{
		Gun g = new Gun(3);

		g.shoot();
		g.shoot();
		g.shoot();
		g.shoot();
		g.shoot();

		g.setAmmo(10);
	}
}
