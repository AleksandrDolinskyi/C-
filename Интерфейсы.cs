using System;
namepsace ProjectOne {
	interface ISomeInterface{
		int property {get; set;}
		void Print ();
	}
	class Test_1 : ISomeInterface {
		public int property {get; set;}
		public void Print () {
			Console.WriteLine("Some text");
		}
	}
	class Test_2 : ISomeInterface {
		public int property {get; set;}
		public void Print () {
			Console.WriteLine("This is text");
		}
	}
	class MainClass {
		public static void Main (string[] args) {
			Test text_1 = new Test ();
			Test test_2 = new Test_2;
			text_1.property = 12;
			test_1.Print();
			Console.WriteLine(test_1.property);
			Console.WriteLine();
			test_2.property = 15;
			test_2.Print();
			Console.WriteLine(test_2.property);
			Console.ReadLine();
		}
	}
}