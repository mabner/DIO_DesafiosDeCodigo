// using System;

// class Desafio
// {
// 	static void Main()
// 	{
// 		int limit = Int32.Parse(Console.ReadLine());
// 		for (int i = 0; i < limit; i++)
// 		{
// 			string[] line = Console.ReadLine().Split(" ");
// 			double x = double.Parse(line[0]);
// 			double y = double.Parse(line[1]);
// 			double divisao = x / y;
// 			if (y == 0)
// 			{
// 				Console.WriteLine("divisao impossivel");
// 			}
// 			else
// 			{
// 				Console.WriteLine(Math.Round(divisao, 1).ToString("F1"));
// 			}
// 		}
// 	}
// }