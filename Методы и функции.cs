using System;
namespace ProjectOne {
	class MainClass {
		public static void Main (string[] args) {
			WriteHello ("Hello");
			int num_1 = Convert.ToInt32(Console.ReadLine());
			int num_2 = Convert.ToInt32(Console.ReadLine());
			int result = Multyply (num_1,num_2);
			Console.WriteLine("Result is " + result);
			Console.ReadKey();
		}
		public static void WriteHello (string str) {
			Console.WriteLine(str);
		}
		public static void Multyply (int num_1, int num_2) {
			return num_1 * num_2;
		}
	}
}