using System;

namespace ProjectOne {

	class Animal {	

	public static int count = 0;
	public string name;
	public int age;
	public float hapiness;

	// Конструктор
	public Animal {
		name = "Sporty";
		age = 7;
		hapiness 0.7f;
		count++;
		Print();
	}

	public Animal (string _name, int _age, float _hapiness) {
		name = _name;
		age = _age;
		hapiness = _hapiness;
		count++;
		Print();
	}

	public void Print (){
		Console.WriteLine("Name:" + name);
		Console.WriteLine("Age:" + age);
		Console.WriteLine("hapiness:" + hapiness);
	}
}

class MainClass {
	public static void Main (string[] args) {
		Animal cat = new Animal();
		Console.WriteLine();
		Animal dog = new Animal("Tom", 12, 8.997);
		Console.WriteLine("Count of animal: " + Animal.count);
		Console.ReadKey();
	}
}