/*
Descrição
Crie uma função que calcula o montante final de um investimento com base em juros compostos.
Essa função ajudará os investidores a compreenderem o crescimento potencial de seus
investimentos ao longo do tempo. Os juros compostos são calculados não apenas sobre
o investimento inicial, mas também sobre os juros acumulados ao longo dos períodos anteriores,
o que resulta em um crescimento exponencial do valor investido.

A fórmula para calcular o montante final (A) em juros compostos é:

A = P × ( 1 + i ) ^ n

Onde:

P é o valor inicial do investimento.
i é a taxa de juros anual.
n é o número de anos
Entrada
A entrada é composta por três strings, representando os parâmetros:

P: O valor inicial do investimento (principal).
i: A taxa de juros anual (expressa como um decimal). Por exemplo, 5% deve ser representado como 0.05.
n: O número de anos que o dinheiro será investido.
Esses valores serão fornecidos na seguinte ordem: P, i, n.

Saída
A função deverá retornar o montante final após o período de investimento, considerando a
capitalização dos juros (juros compostos). O resultado deve ser um número representando o
valor total após a aplicação dos juros compostos sobre o investimento inicial ao longo do tempo especificado. 

Exemplos
A tabela abaixo apresenta exemplos com alguns dados de entrada e suas respectivas
saídas esperadas. Certifique-se de testar seu programa com esses exemplos e com outros casos possíveis.

Entrada         Saída
2000            2249.728
0.04
3

1500            1687.296
0.04
3

1000            1102.5
0.05
2

*/

using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Solicita ao usuário para inserir os valores
        double P = Convert.ToDouble(Console.ReadLine());
        double i = Convert.ToDouble(Console.ReadLine());
        int n = Convert.ToInt32(Console.ReadLine());

        // Calcula o montante final utilizando a função CalcularJurosCompostos
        double montanteFinal = CalcularJurosCompostos(P, i, n);

        // Exibe o resultado
        Console.WriteLine(montanteFinal);
    }

    public static double CalcularJurosCompostos(double P, double i, int n)
    {
       double A = P * Math.Pow(1 + i, n);
       return A;
    }
}

