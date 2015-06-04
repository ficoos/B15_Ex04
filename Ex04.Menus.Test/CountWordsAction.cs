using System;

using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
	public class CountWordsAction : IMenuItemAction
	{
		private static readonly char[] sr_Whitespace = { ' ', '\t', '\n', '\r' };

		public void Invoke()
		{
			Console.WriteLine("Please enter a sentence:");
			string sentence = Console.ReadLine();
			Console.WriteLine("The sentence has {0} words in it", sentence.Split(sr_Whitespace, StringSplitOptions.RemoveEmptyEntries).Length);
			Console.ReadKey();
		}
	}
}