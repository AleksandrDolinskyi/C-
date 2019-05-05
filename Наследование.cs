using System; 
namespace ProjectOne {
	class Animal {
		public string Name {get; set;}
		public Animal (string name) {
			Name = name;
		}
		public void Print () {
			Console.WriteLine(Name);
		}
	}
	class Dog : Animal {
		private float speed;
		Dog () {
			Dog (float speed, string name) : base (name) {
				this.speed = speed;
				Console.WriteLine("Speed: " + speed);
			}
		}
	}
	class MainClass {
		public static void Main (string[] args) {
			Dog tom = new Dog (12.23f, "Tom");
			Console.WriteLine(tom.Name);
			Console.ReadKey();
		}
	}
}