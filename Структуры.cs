using System;
namespace ProjectOne {
	struct Book {
		public string title;
		public string name;
		public string author;
	}
	class MainClass {
		public static void Main (string[] args) {
			Book b;
			b.author = "Sing";
			Console.ReadLine();
		}
	}
}