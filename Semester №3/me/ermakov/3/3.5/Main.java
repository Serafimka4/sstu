public class Main {
	public static void main(String[] args)
	{
		Publication publication = new Publication(
			"История транзистора",
			"Дорога к твердотельным переключателям была долгой. Она началась с открытия того, что определенные материалы странно ведут себя в присутствии электричества. В 1874 году Фердинанд Браун опубликовал статью “О прохождении электрических токов через сульфиды металлов”. И все завертелось…",
			new String [] {"История", "IT", "Электроника"},
			new Comment [] {
				new Comment("Держите ссылку на то как работают светодиоды из карбида кремния ввв.свет.ру", 1, new Comment [] {
					new Comment("Спасибо!", 0, null),
					new Comment("Thanks!", 0, null),
				}),
				new Comment("Это перевод? Пойду оригинал почитаю", 0, new Comment [] {
					new Comment("а где ссылка на оригинал?", 0, new Comment [] {
						new Comment("автор, добавь ссылку в начало статьи", 3, null)
					})
				}),
				new Comment("Какую только дичь не писали в журналах 20-30гг пытаясь объяснить работу кристаллического детектора", 5, null)
			},
			10
		);

		System.out.println(publication);
	}
	
	public static String removeLastChar(String s)
	{
		return s.substring(0, s.length() - 1);
	}
}
