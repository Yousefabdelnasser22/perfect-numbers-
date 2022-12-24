using System;
using System.Linq;

namespace Perfect_numbers
{
	public static class Program
	{
		public static void Main()
		{
			Console.WriteLine("please enter number1");
			int num1 = int.Parse(Console.ReadLine());
			
			Console.WriteLine("please enter number2");
			int num2 = int.Parse(Console.ReadLine());
			
			Console.WriteLine(" the perfect numbers between number1 and number2 is ");
			for(int i = num1 ; i<=num2 ; i++)
		{
			if(Isperfect(i)) Console.WriteLine("{0}",i);
		}
		}
			public static bool Isperfect(int number)
		{
			int sum =0;
			for (int i=1 ; i< number; i++)
			{
				if (number % i ==0) sum=sum+i;
			}
			if (sum == number) return true ;
			return false;
		}

		}
	}
