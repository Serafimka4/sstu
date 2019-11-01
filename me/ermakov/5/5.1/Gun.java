public class Gun {
	private int ammo;
	final int maxAmmo;
	static final int DEFAULT_MAX_AMMO = 9;
	static final int DEFAULT_AMMO = 3;

	public Gun(int ammo, int maxAmmo)
	{
		this.ammo  = ammo;
		this.maxAmmo = maxAmmo;
	}

	public Gun()
	{
		this(Gun.DEFAULT_AMMO, Gun.DEFAULT_MAX_AMMO);
	}

	public Gun(int maxAmmo)
	{
		this(maxAmmo, maxAmmo);
	}

	public void setAmmo(int ammo)
	{
		if (ammo > this.maxAmmo)
			this.ammo = this.maxAmmo;

		this.ammo = ammo;
	}

	public void shoot()
	{
		if (this.ammo == 0) {
			System.out.println("Клац!");
		} else {
			System.out.println("Бах!");
			this.ammo--;
		}
	}
}
