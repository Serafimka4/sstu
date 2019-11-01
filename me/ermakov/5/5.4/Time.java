public class Time {
	int secondsSinceDayStart;

	public Time(int s)
	{
		this.secondsSinceDayStart = s;
	}

	public Time(int h, int m, int s)
	{
		this.secondsSinceDayStart = h * 3600 + m * 60 + s;
	}

	public int getHour()
	{
		return (int) Math.floor(this.secondsSinceDayStart / 3600) % 24;
	}

	public int getMinute()
	{
		return (int) Math.floor((this.secondsSinceDayStart % 3600) / 60);	
	}

	public int getSecond()
	{
		return this.secondsSinceDayStart % 60;	
	}

	public String toString()
	{
		return String.format("%02d:%02d:%02d", getHour(), getMinute(), getSecond());
	}
}
