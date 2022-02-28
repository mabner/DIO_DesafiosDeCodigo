// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

class Program
{

	static void Main(string[] args)
	{
		// Utilize Console.ReadLine para leitura do input de cada linha
		// Utilize Console.WriteLine para fazer o output de cada linha

		do
		{
			var[] joiasLista = Console.ReadLine().Split('\n');
		} while (!String.IsNullOrEmpty(joiasLista));

		var joiasDistintas = joiasLista.Distinct();

		int countJoias = joiasDistintas.Count();

		System.Console.WriteLine(countJoias);
	}
}