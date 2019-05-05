using System;

namepsace ProjectOne {
	inu, Breed { Dog, Cat, Bird, Bear, Tiger};
	class Animal {
		public Breed breed;
		public Animal (Breed breed) {
			this.breed = breed;
		}
		public void Print () {
			Console.WriteLine(breed);
		}
	}

	class MainClass {
		public static void Main (string[] args) {
			Animal dog = new Animal(Breed.Bird);
			dog.Print();
			Console.ReadLine();
		}
	}
}