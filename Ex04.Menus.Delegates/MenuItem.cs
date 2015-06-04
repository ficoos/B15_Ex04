using System;

namespace Ex04.Menus.Delegates
{
	public class MenuItem : IMenuItem
	{
		public delegate void MenuActionDelegate();

		public event MenuActionDelegate Shown;

		internal MenuItem(string i_Title)
		{
			this.Title = i_Title;
		}

		public string Title { get; set; }

		public void Show()
		{
			Console.Clear();
			this.OnShown();
		}

		protected virtual void OnShown()
		{
			MenuActionDelegate handler = this.Shown;
			if (handler != null)
			{
				handler();
			}
		}
	}
}