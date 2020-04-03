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

	public String toString()
	{
		int s = this.secondsSinceDayStart % 60;
		int m = (int) Math.floor((this.secondsSinceDayStart % 3600) / 60);
		int h = (int) Math.floor(this.secondsSinceDayStart / 3600);

		h %= 24;

		return String.format("%02d:%02d:%02d", h, m, s);
	}
}
