public class City {
	String name;
	PathToCity [] pathToCities;

	public City(String name)
	{
		this.name = name;
	}

	public String toString()
	{
		String result = this.name + "\n";

		for (PathToCity p : this.pathToCities)
			result += "\t" + p + "\n";

		return result;
	}
}
