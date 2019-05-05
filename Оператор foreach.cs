using System;
namespace ProjectOne {
	class MainClass {
		public static void Main (string[]) {
			float[] numbers = {1.237,23.237,23,57f};
			foreach (float el in numbers){
				Console.WriteLine(el);
			}
			Console.ReadKey();
		}
	}
}