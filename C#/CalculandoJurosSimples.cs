/*
Descrição
Você foi contratado por uma corretora de investimentos para criar uma função que calcula o montante final
de um investimento baseado em juros simples. O objetivo é ajudar os clientes a entenderem quanto seu
investimento valerá após um determinado período.

A fórmula para calcular o montante final (A) em juros simples é:

A = P + (P × i × n)

Onde:

P é o valor inicial do investimento.
i é a taxa de juros anual.
n é o número de anos.

Entrada
A entrada é composta por três strings, representando os parâmetros:

P: O valor inicial do investimento (principal).
i: A taxa de juros anual (expressa como um decimal). Por exemplo, 5% deve ser representado como 0.05.
n: O número de anos que o dinheiro será investido.
Esses valores serão fornecidos na seguinte ordem: P, i, n.

Saída
A função deverá retornar o montante final após o período de investimento, considerando a capitalização
dos juros (juros compostos). O resultado deve ser um número representando o valor total após a
aplicação dos juros compostos sobre o investimento inicial ao longo do tempo especificado.

Exemplos
A tabela abaixo apresenta exemplos com alguns dados de entrada e suas respectivas saídas esperadas.
Certifique-se de testar seu programa com esses exemplos e com outros casos possíveis.

Entrada	    Saída
1000        1100
0.05
2

1500        1725
0.03
5

2000        2240
0.04
3
*/

using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Solicita ao usuário para inserir os valores
        double P = Convert.ToDouble(Console.ReadLine()); // Lê o valor principal P

        double i = Convert.ToDouble(Console.ReadLine()); // Lê a taxa de juros i

        int n = Convert.ToInt32(Console.ReadLine()); // Lê o número de períodos n

        // Calcula o montante final utilizando a função CalcularJurosSimples
        double montanteFinal = CalcularJurosSimples(P, i, n);

        // Exibe o resultado
        Console.WriteLine(montanteFinal); // Mostra o montante final calculado
    }

    public static double CalcularJurosSimples(double P, double i, int n)
    {
        // TODO: Calcule e retorne o montante final com juros simples
    }
}
