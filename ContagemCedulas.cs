using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafiosDeCodigo
{
	/*
    Faça a leitura de um valor inteiro. Em seguida, calcule o menor número de notas possíveis (cédulas) onde o valor pode ser decomposto.
    As notas que você deve considerar são de 100, 50, 20, 10, 5, 2 e 1. Na sequência mostre o valor lido e a relação de notas necessárias.

    .:: Entrada ::.
    Você receberá um valor inteiro N (0 < N < 1000000).

    .:: Saída ::.
    Exiba o valor lido e a quantidade mínima de notas de cada tipo necessárias, seguindo o exemplo de saída abaixo. Após cada linha deve ser imprimido o fim de linha.

    Exemplo de Entrada 	Exemplo de Saída
            576        |     576
                       |     5 nota(s) de R$ 100,00
                       |     1 nota(s) de R$ 50,00
                       |     1 nota(s) de R$ 20,00
                       |     0 nota(s) de R$ 10,00
                       |     1 nota(s) de R$ 5,00
                       |     0 nota(s) de R$ 2,00
                       |     1 nota(s) de R$ 1,00

            11257 	   |     11257
                       |     112 nota(s) de R$ 100,00
                       |     1 nota(s) de R$ 50,00
                       |     0 nota(s) de R$ 20,00
                       |     0 nota(s) de R$ 10,00
                       |     1 nota(s) de R$ 5,00
                       |     1 nota(s) de R$ 2,00
                       |     0 nota(s) de R$ 1,00

            503 	   |     503
                       |     5 nota(s) de R$ 100,00
                       |     0 nota(s) de R$ 50,00
                       |     0 nota(s) de R$ 20,00
                       |     0 nota(s) de R$ 10,00
                       |     0 nota(s) de R$ 5,00
                       |     1 nota(s) de R$ 2,00
                       |     1 nota(s) de R$ 1,00
    */

	public class ContagemCedulas
	{
		static void Main(string[] args)
		{
			int n, nota, quociente, resto;

			n = int.Parse(Console.ReadLine());
			Console.WriteLine(n);

			resto = n;

			nota = 100;
			quociente = resto / 100;
			Console.WriteLine($"{quociente} nota(s) de R$ {nota},00");
			resto = resto % 100;

			nota = 50;
			quociente = resto / 50;
			Console.WriteLine($"{quociente} nota(s) de R$ {nota},00");
			resto = resto % 50;

			nota = 20;
			quociente = resto / 20;
			Console.WriteLine($"{quociente} nota(s) de R$ {nota},00");
			resto = resto % 20;

			nota = 10;
			quociente = resto / 10;
			Console.WriteLine($"{quociente} nota(s) de R$ {nota},00");
			resto = resto % 10;

			nota = 5;
			quociente = resto / 5;
			Console.WriteLine($"{quociente} nota(s) de R$ {nota},00");
			resto = resto % 5;

			nota = 2;
			quociente = resto / 2;
			Console.WriteLine($"{quociente} nota(s) de R$ {nota},00");
			resto = resto % 2;

			nota = 1;
			quociente = resto / 1;
			Console.WriteLine($"{quociente} nota(s) de R$ {nota},00");
			resto = resto % 1;



		}
	}
}
