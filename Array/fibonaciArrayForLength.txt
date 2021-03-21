using System;
					
public class Program
{
	public static void Main()
	{
		int [] fibonaci = new int [10];
		fibonaci[0] = 1;
		fibonaci[1] = 1;
		for(int i = 2; i < 10; i++)
		{
			fibonaci[i] = fibonaci[i - 1] + fibonaci[i - 2];
		}
		for(int i = 0; i < fibonaci.Length; i++)
		{
			Console.WriteLine(" " + fibonaci[i]);
		}
	}
}