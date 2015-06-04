using System;

using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
	public class VersionAction : IMenuItemAction
	{
		public void Invoke()
		{
			Console.WriteLine("Version: 15.2.4.0");
			Console.ReadKey();
		}
	}
}