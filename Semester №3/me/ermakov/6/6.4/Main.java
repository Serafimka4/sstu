public class Main {
	public static void main(String[] args)
	{
		Fraction a = new Fraction(4, 10);
		Fraction b = new Fraction(7, 12);

		System.out.println(String.format("%s * %s = %s", a, b, Fraction.Product(a, b)));
		System.out.println(String.format("%s / %s = %s", a, b, Fraction.Quotient(a, b)));
		System.out.println(String.format("%s + %s = %s", a, b, Fraction.Sum(a, b)));
		System.out.println(String.format("%s - %s = %s", a, b, Fraction.Difference(a, b)));

		System.out.println(String.format("%s * %d = %s", a, 3, Fraction.Product(a, 3)));
		System.out.println(String.format("%s / %d = %s", a, 3, Fraction.Quotient(a, 3)));
		System.out.println(String.format("%s + %d = %s", a, 3, Fraction.Sum(a, 3)));
		System.out.println(String.format("%s - %d = %s", a, 3, Fraction.Difference(a, 3)));
	}
}
