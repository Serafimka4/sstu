public class Main {
	public static void main(String[] args)
	{
		Comment a = new Comment("что-то я ничего не понял", 0, null);
		Comment b = new Comment("совершенно согласен с этим комментарием!", 5, a);
		Comment c = new Comment("отличные задачи!", 169, b);

		printCommentsTree(c);
	}

	public static void printCommentsTree(Comment begin)
	{
		String indentation = "";

		do {
			System.out.printf("%s%s\n", indentation, begin);

			begin = begin.childComment;
			indentation += "    ";
		} while (begin != null);
	}
}
