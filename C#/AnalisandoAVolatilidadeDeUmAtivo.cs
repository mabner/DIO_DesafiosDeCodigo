/*
Descrição
Você foi contratado por uma empresa de análise financeira para desenvolver uma função
que calcula a volatilidade histórica de um ativo. A volatilidade é uma medida da variação
dos retornos de um ativo ao longo do tempo e é fundamental para avaliar o risco associado
ao investimento.

O cálculo do desvio padrão, que mede essa volatilidade, envolve os seguintes passos:

-   Calcular a Média: Primeiramente, é necessário calcular a média dos preços de fechamento.
    A média é obtida somando todos os preços e dividindo pelo número de dias.
-   Calcular as Diferenças Quadráticas: Para cada preço de fechamento, calcular a diferença em
    relação à média e elevar ao quadrado.
-   Calcular a Variância: A variância é a média das diferenças quadráticas calculadas.
-   Calcular o Desvio Padrão: Finalmente, o desvio padrão é a raiz quadrada da variância.

Entrada
A entrada consiste em uma string representando uma lista de preços de fechamento diários do
ativo financeiro ao longo de um período. Os preços são separados por vírgula e espaço (, ).

Saída
Deve-se retornar o desvio padrão dos preços de fechamento, que é utilizado como medida de
volatilidade do ativo para o período fornecido.

Exemplos
A tabela abaixo apresenta exemplos com alguns dados de entrada e suas respectivas saídas esperadas.
Certifique-se de testar seu programa com esses exemplos e com outros casos possíveis.

Entrada                                 Saída
100.0, 102.5, 99.8, 101.2, 98.5	        1.355
50.2, 51.0, 49.5, 52.1, 48.9, 50.8      1.041
200.5, 198.7, 203.1, 197.4, 201.9       2.069

*/

using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Lê a string de entrada contendo os preços de fechamento
        string input = Console.ReadLine();

        // Separa os preços de fechamento em um array de strings
        string[] precosStr = input.Split(',');

        // Converte os preços de fechamento para um array de doubles
        double[] precos = Array.ConvertAll(precosStr, Double.Parse);

        // Calcula a volatilidade histórica (desvio padrão)
        double volatilidade = CalcularVolatilidade(precos);

        // Exibe o resultado formatado com três casas decimais
        Console.WriteLine($"{volatilidade:F3}");
    }

    public static double CalcularVolatilidade(double[] precos)
    {
        // Calcula a média dos preços de fechamento
        double media = CalcularMedia(precos);

        // Calcula as diferenças quadráticas em relação à média e somar
        double somaDiferencasQuadraticas = 0;
        foreach (double preco in precos)
        {
            double diferenca = preco - media; // Calcula a diferença entre o preço e a média
            somaDiferencasQuadraticas += diferenca * diferenca; // Soma as diferenças quadráticas
        }

        // TODO: Calcule a variância dividindo a soma das diferenças quadráticas pelo número de dias
        double variancia = somaDiferencasQuadraticas / precos.Length;

        // Calcula o desvio padrão (raiz quadrada da variância)
        double desvioPadrao = Math.Sqrt(variancia);

        return desvioPadrao; // Retorna o desvio padrão (volatilidade)
    }

    public static double CalcularMedia(double[] precos)
    {
        double soma = 0;
        foreach (double preco in precos)
        {
            soma += preco;
        }

        return soma / precos.Length;
    }
}