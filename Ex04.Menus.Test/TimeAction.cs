using System;

using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
	public class TimeAction : IMenuItemAction
	{
		public void Invoke()
		{
			Console.WriteLine("The time is {0}, press any key to continue", DateTime.Now.TimeOfDay);
			Console.ReadKey();
		}
	}
}