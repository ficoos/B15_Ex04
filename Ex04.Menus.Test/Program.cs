namespace Ex04.Menus.Test
{
	public class Program
	{
		public static void Main()
		{
			showInterfaceMenu();
			showDelegateMenu();
		}

		private static void showInterfaceMenu()
		{
			Interfaces.MainMenu menu = new Interfaces.MainMenu("Interface Menu Tests");
			Interfaces.IMenu datimeMenu = menu.AddMenu("Show Data/Time");
			datimeMenu.AddItem("Show Time", new TimeAction());
			datimeMenu.AddItem("Show Date", new DateAction());
			Interfaces.IMenu infoMenu = menu.AddMenu("Info");
			infoMenu.AddItem("Show Version", new VersionAction());
			infoMenu.AddItem("Count Words", new CountWordsAction());
			menu.Show();
		}

		private static void showDelegateMenu()
		{
			Delegates.MainMenu menu = new Delegates.MainMenu("Delegate Menu Tests");
			Delegates.MainMenu datimeMenu = menu.AddMenu("Show Data/Time");
			datimeMenu.AddItem("Show Time").Shown += new TimeAction().Invoke;
			datimeMenu.AddItem("Show Date").Shown += new DateAction().Invoke;
			Delegates.MainMenu infoMenu = menu.AddMenu("Info");
			infoMenu.AddItem("Show Version").Shown += new VersionAction().Invoke;
			infoMenu.AddItem("Count Words").Shown += new CountWordsAction().Invoke;
			menu.Show();
		}
	}
}
