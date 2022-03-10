// using System;
// using System.Collections.Generic;
// using System.Linq;

// class Program
// {

// 	static void Main(string[] args)
// 	{
// 		// Utilize Console.ReadLine para leitura do input de cada linha
// 		// Utilize Console.WriteLine para fazer o output de cada linha

// 		var tesouro = new List<string>();
// 		var joiasDistintas = new List<string>();

// 		do
// 		{
// 			tesouro.Add(Console.ReadLine());
// 		} while (!String.IsNullOrEmpty(tesouro.Last()));

// 		joiasDistintas = tesouro.SkipLast(1).Distinct().ToList();

// 		System.Console.WriteLine(joiasDistintas.Count);
// 	}
// }
