using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafiosDeCodigo
{
	/*
    O programa deve ler um valor inteiro D indefinidas vezes, ele só irá parar quando o valor de D for igual a 0.
    Para cada D lido, imprima a soma dos 5 pares consecutivos a partir de D, inclusive ele mesmo , se for par.

    Se o valor de entrada for 4, por exemplo, a saída deve ser 40, que é o resultado da operação: 4+6+8+10+12,
    enquanto que se o valor de entrada for 11, por exempo, a saída deve ser 80, que é a soma de 12+14+16+18+20.

    .:: Entrada ::.
    O arquivo de entrada contém muitos valores inteiros. O último valor do arquivo é zero.

    .:: Saída ::. 
    Imprima a saida conforme a explicação acima e o exemplo abaixo.

    Exemplo de Entrada 	Exemplo de Saída
        4             |         40
        11            |         80
        0             |
    */
	public class SomaDePares
	{
		static void Main(string[] args)
		{
			int d = int.Parse(Console.ReadLine());

			while (d != 0)
			{
				int soma = 0;
				int pares = 1;

				for (int i = d; pares <= 5; i++)
				{
					if (i % 2 == 0)
					{
						soma += i;
						pares++;
					}
				}
				Console.WriteLine(soma);
				d = int.Parse(Console.ReadLine());
			}

		}
	}
}