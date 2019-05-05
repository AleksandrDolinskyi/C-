using System;

namepsace ProjectOne {
	class Some {
		public void Multiply (int a, int b) {
			Console.WriteLine("Result in: " = a + b);
		}
	}

	class MainClass {
		public static void Main (string[] args) {
			Some test = new Some;
			test.Multiply (2, 23);
			Console.ReadLine();
		}
	}
}