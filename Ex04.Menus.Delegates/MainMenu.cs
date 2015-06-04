using System;
using System.Collections.Generic;

namespace Ex04.Menus.Delegates
{
	public class MainMenu : IMenuItem
	{
		public string Title { get; set; }

		private readonly List<IMenuItem> r_ItemList = new List<IMenuItem>();

		private readonly bool r_IsSubMenu;

		private readonly int r_Depth;

		public MainMenu(string i_Title) : this(i_Title, 1, false)
		{
		}

		internal MainMenu(string i_Title, int i_Depth, bool i_IsSubMenu)
		{
			Title = i_Title;
			r_IsSubMenu = i_IsSubMenu;
			r_Depth = i_Depth;
		}

		public MainMenu AddMenu(string i_Title)
		{
			const bool v_IsSubMenu = true;
			MainMenu menu = new MainMenu(i_Title, r_Depth + 1, v_IsSubMenu);
			r_ItemList.Add(menu);
			return menu;
		}

		public MenuItem AddItem(string i_Title)
		{
			MenuItem item = new MenuItem(i_Title);
			r_ItemList.Add(item);
			return item;
		}

		public void Show()
		{
			bool isRunning = true;
			while (isRunning)
			{
				printMenu();
				int choice = getChoiceFromUser();
				if (choice == r_ItemList.Count)
				{
					isRunning = false;
				}
				else
				{
					r_ItemList[choice].Show();
				}
			}
		}

		private int getChoiceFromUser()
		{
			int choice = -1;
			bool isValidChoice = false;
			while (!isValidChoice)
			{
				Console.Write("Please enter a valid option ({0} - {1}): ", 1, this.r_ItemList.Count + 1);
				string choiceStr = Console.ReadLine();

				if (!int.TryParse(choiceStr, out choice))
				{
					Console.WriteLine("Invalid input, please enter a number");
				}
				else if (choice < 1 || choice > (this.r_ItemList.Count + 1))
				{
					Console.WriteLine("Number not in range");
				}
				else
				{
					isValidChoice = true;
				}
			}

			return choice - 1;
		}

		private void printMenu()
		{
			Console.Clear();
			Console.WriteLine("{0}: {1}", r_Depth, Title);
			int itemCounter = 1;
			foreach (IMenuItem item in this.r_ItemList)
			{
				Console.WriteLine("{0}) {1}", itemCounter, item.Title);
				itemCounter++;
			}

			if (this.r_IsSubMenu)
			{
				Console.WriteLine("{0}) Back", itemCounter);
			}
			else
			{
				Console.WriteLine("{0}) Exit", itemCounter);
			}
		}
	}
}
