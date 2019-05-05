using System;
namespace ProjectOne {
	class Student {
		private string name;
		private int course;
		private bool stipuha;
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
}