public class PathToCity {
	City city;
	int tripCost;

	public PathToCity(City city, int tripCost)
	{
		this.city = city;
		this.tripCost = tripCost;
	}

	public String toString()
	{
		return this.city.name + ": " + tripCost;
	}
}
