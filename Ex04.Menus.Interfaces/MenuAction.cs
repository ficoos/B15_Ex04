namespace Ex04.Menus.Interfaces
{
	using System;

	internal class MenuAction : IMenuItem
	{
		private readonly IMenuItemAction r_Action;

		public MenuAction(string i_Title, IMenuItemAction i_Action)
		{
			Title = i_Title;
			r_Action = i_Action;
		}

		public string Title { get; set; }

		public void Show()
		{
			Console.Clear();
			r_Action.Invoke();
		}
	}
}