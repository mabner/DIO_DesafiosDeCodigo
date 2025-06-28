/*

# Registro de Despesas Válidas #

Descrição
Em uma empresa de soluções financeiras, os dados de despesas são recebidos diariamente para análise.
No entanto, somente despesas com valores positivos devem ser consideradas válidas para o relatório.
Sua tarefa é criar um programa que filtre apenas essas despesas.

Entrada
A entrada deve conter a quantidade total de despesas registradas, seguida dos valores (inteiros) de cada uma.

O primeiro valor representa o número total de despesas.
Os valores seguintes representam cada despesa registrada.

Saída
Deverá exibir apenas os valores válidos (maiores que zero), um por linha.
Caso nenhuma despesa válida seja encontrada, exibir “Sem despesas validas”.

Exemplos
A tabela abaixo apresenta exemplos com alguns dados de entrada e suas respectivas saídas esperadas.
Certifique-se de testar seu programa com esses exemplos e com outros casos possíveis.

Entrada 	Saída
4           100
100         90
-20
0
90

3           Sem despesas validas
-50
-10
0

2           150
150         30
30
 */
using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        int quantidade = int.Parse(Console.ReadLine());
        List<int> despesas = new List<int>();

        for (int i = 0; i < quantidade; i++)
        {
            int valor = int.Parse(Console.ReadLine());
            // TODO: Adicione o valor à lista somente se for maior que zero
            if (valor > 0)
            {
              despesas.Add(valor);
            }
        }

        if (despesas.Count == 0)
        {
            Console.WriteLine("Sem despesas validas");
        }
        else
        {
            // TODO: Imprima cada valor da lista de despesas válidas
            foreach (int despesa in despesas)
            {
              Console.WriteLine(despesa);
            }
        }
    }
}