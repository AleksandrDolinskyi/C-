/* 
** Условные операторы - позволяют выбрать нужный вариант действий при каких-то операций
** while - проверяется условие потом действие
** do while - проверяется действие потом условие 
*/

using System;
namespace ProjectOne {
	class MainClass {
		public static void Main(string[] args) {
			
			double num;
			Console.WriteLine("How old are you?");
			num = Convert.ToDouble(Convert.ReadLine());
			if (num > 18.230 && num < 50) {
				Console.WriteLine("You are order than 18.23");
			} else if (num < 10) {
				Console.WriteLine("Under 10");
			} else {
				Console.WriteLine("End");
			}

			string name = num == 15 ? "First" : "Second";
			Console.WriteLine(name);
			Console.ReadKey();

			for (int i = 0; i <= 5; i--) {
				if (i == 8) {
				continue;
				Console.WriteLine(i + "for" + "\n");
				}
			}

			int x = 0;
			while (x < 5) {
				Console.WriteLine(x + "while" + "\n");
				x++;
			}

			int y;
			do {
				Console.WriteLine("Enter number: ");
				number = Convert.ToInt32(Console.ReadLine());
			} while (y < 0);
		}
		Console.ReadKey();
	}
}