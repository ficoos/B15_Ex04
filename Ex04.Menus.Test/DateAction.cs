using System;

using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
	public class DateAction : IMenuItemAction
	{
		public void Invoke()
		{
			Console.WriteLine("The data is {0}, press any key to continue", DateTime.Now.Date.ToLongDateString());
			Console.ReadKey();
		}
	}
}