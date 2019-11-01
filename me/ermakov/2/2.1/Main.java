public class Main {
	public static void main(String[] args)
	{
		Point a = new Point(1, 3);
		Point b = new Point(23, 8);
		Point c = new Point(5, 10);
		Point d = new Point(25, 10);

		Line line1 = new Line(a, b);
		Line line2 = new Line(c, d);
		Line line3 = new Line(line1.begin, line2.end);

		System.out.printf("1: %s\n", line1);
		System.out.printf("2: %s\n", line2);
		System.out.printf("3: %s\n\n", line3);

		/* Покажем, что координаты третьей линии привязаны к координатам
		   первых двух линий: */

		line1.begin.x = 10;
		line2.end.x = 13;

		System.out.printf("3: %s\n\n", line3);

		/* Изменим координаты первой линии так, чтобы отвязать ее от третьей: */

		line1.begin = new Point(18, 18);

		System.out.printf("1: %s\n", line1);
		System.out.printf("2: %s\n", line2);
		System.out.printf("3: %s\n", line3);
	}
}
