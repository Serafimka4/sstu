public class Time {
	int secondsSinceDayStart;

	public Time(int s)
	{
		secondsSinceDayStart = s;
	}

	public String toString()
	{
		int ss = secondsSinceDayStart % 60;
		int mm = (int) Math.floor((secondsSinceDayStart % 3600) / 60);
		int hh = (int) Math.floor(secondsSinceDayStart / 3600);

		hh %= 24;

		return String.format("%02d:%02d:%02d", hh, mm, ss);
	}
}
