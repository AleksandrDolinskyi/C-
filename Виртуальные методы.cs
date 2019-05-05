using System;

namespace ProjectOne {
class Shape {
    public virtual void saysSomething () {
      Console.Write("No! ");
    }
}


class Square : Shape {

	public override void saysSomething () {
		base.saysSomething ();
		Console.Write("But I will say something!");
	}
		
}


class MainClass {
    public static void Main(String[] args) {
        Square test = new Square();
        test.saysSomething (); 
    }
  }
}