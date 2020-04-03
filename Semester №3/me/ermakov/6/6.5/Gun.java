public class Gun {
	private int ammo;
	private final int maxAmmo;

	static final int DEFAULT_MAX_AMMO = 9;
	static final int DEFAULT_AMMO = 3;

	public Gun(int ammo, int maxAmmo)
	{
		this.maxAmmo = maxAmmo;
		setAmmo(ammo);
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

	public int getMaxAmmo()
	{
		return this.maxAmmo;
	}

	public int reload(int ammo)
	{
		if (ammo < 0)
			throw new IllegalArgumentException("Can not reload negative count of ammo.");

		setAmmo(ammo);

		return this.maxAmmo - ammo;
	}

	public int discharge()
	{
		final int oldAmmo = this.ammo;
		setAmmo(0);
		return oldAmmo;
	}

	public int getAmmo()
	{
		return this.ammo;
	}

	public boolean isLoaded()
	{
		return this.ammo > 0;
	}
}
