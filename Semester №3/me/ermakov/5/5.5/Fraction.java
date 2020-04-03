public class Fraction {
	int numerator;
	int denominator;

	public Fraction(int numerator, int denominator)
	{
		if (denominator == 0)
			throw new IllegalArgumentException("Denominator of a fraction can't be 0.");

		this.numerator = numerator;
		this.denominator = denominator;
	}

	public String toString()
	{
		return String.format("%d/%d", this.numerator, this.denominator);
	}

	public static Fraction Product(Fraction a, Fraction b)
	{
		return new Fraction(a.numerator * b.numerator, a.denominator * b.denominator);
	}

	public static Fraction Quotient(Fraction a, Fraction b)
	{
		return new Fraction(a.numerator * b.denominator, a.denominator * b.numerator);
	}

	public static Fraction Sum(Fraction a, Fraction b)
	{
		/* Make sure the denominators are the same: */
		final int n = a.numerator * b.denominator + b.numerator * a.denominator;
		final int d = a.denominator * b.denominator;

		return new Fraction(n, d);
	}

	public static Fraction Difference(Fraction a, Fraction b)
	{
		return Fraction.Sum(a, Fraction.Product(b, -1));
	}

	public static Fraction Product(Fraction a, int n)
	{
		Fraction temp = new Fraction(n, 1);
		return Fraction.Product(a, temp);
	}

	public static Fraction Quotient(Fraction a, int n)
	{
		Fraction temp = new Fraction(n, 1);
		return Fraction.Quotient(a, temp);
	}

	public static Fraction Sum(Fraction a, int n)
	{
		Fraction temp = new Fraction(n, 1);
		return Fraction.Sum(a, temp);
	}

	public static Fraction Difference(Fraction a, int n)
	{
		Fraction temp = new Fraction(n, 1);
		return Fraction.Difference(a, temp);
	}
}

