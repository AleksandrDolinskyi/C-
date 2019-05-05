using System;
using System.Collections.Generic;
namespace ProjectOne {
	class MainClass {
		publick static void Main (string[] args) {
			string[] names = new string[3]{
				"Tom", "John", "George";
			}
			for (int i = 0; i < names.length; i++){
				Console.WriteLine(names [i] + "\n");
			}
			int[] array = new int[5]; 
			array[0] = 24;
			array[1] = 4;
			array[2] = 2;
			array[3] = 7;
			array[4] = 56;
			for (int i = 0; i < array.length; i++){
				Console.WriteLine(array [i] + "\n");
			}
			int[,] number = new number[5,5];
			number [1,2] = 23;
			Console.WriteLine(number[i]);
			Console.ReadKey();
		}
	}
}