using System;
					
public class Program
{
	public static void Main()
	{
		//strings
		string hello = "Hello world";
		Console.WriteLine(hello);
		// ints and arithmetic operaters
		int myNum = 15;
		int myNum2 = 5;
		//Multiplys myNum2 by three than adds myNum
		int myAns = myNum + myNum2 * 3;
		Console.WriteLine(myAns);
		//Bools and Logical
		bool nay = false;
		//Takes false and ! makes it True
		bool yay = ! nay ;
		Console.WriteLine(yay);
		//Comparison is myNum is less than mynum2
		Console.WriteLine(myNum < myNum2);
		
	}
}