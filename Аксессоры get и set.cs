using System;
namespace ProjectOne {
	class Student {	
		private string name;
		private int course;
		private bool stipuha;
		public int Course {
			// Запись
			get {
				return course;
			}
			// Чтение
			set {
				if (value < 1) {
					course = 1;
				} else if (value > 5) {
					course = 5;
				} else {
					course = value;
				}
			}
		}

	public Student () {
			name = "Alex";
			course = 2;
			stipuha = true;
			PrintAll();
	}

	public Student (string name, int course, bool stipuha) {
			this.name = name;
			this.course = course;
			this.stipuha = stipuha;
			PrintAll();
	}

	public void PrintAll () {
			Console.WriteLine("Name: " + name);
			Console.WriteLine("Course: " + course);
			Console.WriteLine("Stipuha: " + stipuha);
		}
	}

	class MainClass {
			public static void Main (string[] args) {
				Student Alex = new Student ();
				Alex.Course = 6;
				Console.WriteLine(Alex.Course);
				Console.ReadKey();
			}
		}
}