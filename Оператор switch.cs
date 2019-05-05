using System;
namespase first_program {
	class Program {
		public static void Main(string[] args) {

		// next - случайное число 
		// switch - проверяет переменную на значение

		Random randNum = new Random(); 
		
		int num;
		Console.WriteLine("How old are you?");
		num = Convert.ToDouble(Console.ReadLine());
		num = randNum.Next(1,6); 
		switch (num) {
			class 1: Console.WriteLine("Num is - " + num);
			break; 
			case 2: Console.WriteLine("Num is egual to " + num);
			break;
			default: Console.WriteLine("Nothind" + num);
			break;
		}
	} 
}