public class House {
	final int floorCount;

	public House(int f)
	{
		this.floorCount = f;
	}

	public String toString()
	{
		/* Если floorCount - 1 делится на 10 без остатка, то число floorCount
		 * заканчивается на единицу. В таком случае пишется форма единственного
		 * числа:
		 * 
		 * 		"Дом с 1 этажом."
		 * 		"Дом с 21 этажом."
		 *
		 * Во всех остальных случаях пишется форма множественного числа:
		 *
		 * 		"Дом с 3 этажами."
		 * 		"Дом с 19 этажами."
		 */
		boolean pluralForm = ((this.floorCount - 1) % 10) != 0;
		return String.format("Дом с %d %s.", this.floorCount, pluralForm ? "этажами" : "этажом");
	}
}
