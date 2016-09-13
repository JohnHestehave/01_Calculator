using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using _01_Calculator;

namespace CalculatorApplication
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] sum1 = new int[3] { 1, 2, 3 };
			int res = Calculator.Sum(sum1);
			Console.WriteLine(res);
			Regex o = new Regex(@"[^\d]");
			Console.WriteLine("Indtast et tal:");
			string input = Console.ReadLine();
			input = o.Replace(input, "");
			int i = Convert.ToInt32(input);
			Console.WriteLine("Næste tal:");
			string input2 = Console.ReadLine();
			input2 = o.Replace(input2, "");
			int i2 = Convert.ToInt32(input2);
			Console.WriteLine(i+i2);
			Console.ReadLine();
			
		}
	}
}
