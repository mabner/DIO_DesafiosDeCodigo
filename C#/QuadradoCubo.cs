// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace DesafiosDeCodigo
// {
// 	/*
// 	Você terá o desafio de escrever um programa que leia um valor inteiro N (1 < N < 1000). Este N é a quantidade de linhas de saída que serão apresentadas na execução do programa.

// 	.:: Entrada ::.
// 	O arquivo de entrada contém um número inteiro positivo N.

// 	.:: Saída ::.
// 	Imprima a saída conforme o exemplo fornecido.

// 	Exemplo de Entrada 	Exemplo de Saída

// 			5         |      1 1 1
// 					  |      2 4 8
// 					  |      3 9 27
// 					  |      4 16 64
// 					  |      5 25 125
// 	*/

// 	public class QuadradoCubo
// 	{
// 		static void Main(string[] args)
// 		{
// 			int n = int.Parse(Console.ReadLine());

// 			int inicio = 1;

// 			for (int i = 1; i <= n; i++)
// 			{
// 				System.Console.WriteLine($"{inicio} {Math.Pow(inicio, 2)} {Math.Pow(inicio, 3)}");
// 				inicio++;
// 			}
// 		}
// 	}
// }
