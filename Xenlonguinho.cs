// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

// namespace DIO
// {
// 	class Program
// 	{
// 		static void Main(string[] args)
// 		{
// 			int numero = int.Parse(Console.ReadLine());

// 			for (int i = 0; i < numero; i++)
// 			{
// 				int esferas = int.Parse(Console.ReadLine());
// 				int countEsferas = 0;

// 				for (int j = 1; j <= esferas; j++)
// 				{
// 					int countDivisor = 0;

// 					for (int estrelas = 1; estrelas <= j; estrelas++)
// 					{
// 						if (j % estrelas == 0)
// 						{
// 							countDivisor++;
// 						}

// 					}
// 					if (countDivisor % 2 == 0)
// 					{
// 						countEsferas++;
// 					}
// 				}
// 				System.Console.WriteLine(countEsferas);
// 			}
// 		}
// 	}
// }