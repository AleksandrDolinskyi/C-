using System;
namespace ProjectOne {
	class MainClass {
		public statuc void Main(string[] args){
			string str = "Hello, world!";
			Console.WriteLine(str.length);
			Console.WriteLine(string.IsNullWhiteSpace (str)); // Пробелы, табуляция
			string.Compare("a","b"); // вернет -1
			Console.WriteLine(str.ToLower());
			Console.WriteLine(str.ToUpper());
			Console.WriteLine(str.Contains("el")); // true or false
			Console.WriteLine(str.StartWith("el"));
			Console.WriteLine(str.EndWith("el"));
			Console.WriteLine(str.Insert(5, "ld")); // Вставить  
			Console.WriteLine(str.Remove(5)); // Обрезать  
			Console.WriteLine(str.Replace("World", "Microsoft")); // Заменить
			Char[] sym = str.ToCharArray(); // Преобразовать символ в строку
			stasrs // Разбить символ в строку
		}
		Console.ReadKey();
	}
}