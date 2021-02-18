using System;
					
public class Program
{
		public static void Main()
	{
	  int a = 3;
	  int b = 4;
	  int c = 5;
      int sum = AddIntegers(a, b, c);
      
      Console.WriteLine(sum); //Display the value of sum
	}
	public static int AddIntegers(int a, int b, int c)
	{
		return (a + b + c);
	}


}