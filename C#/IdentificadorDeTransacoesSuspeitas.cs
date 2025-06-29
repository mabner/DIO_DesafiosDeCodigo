/*
# Identificador de Transações Suspeitas #

Descrição
Uma empresa de análise financeira está desenvolvendo um sistema para identificar transações suspeitas com base em um valor limite.
O objetivo do sistema é verificar se alguma transação ultrapassa o valor limite e marcá-la como suspeita.
Se houver transações suspeitas, elas devem ser listadas. Caso contrário, o sistema deve informar que não há transações suspeitas.
Além disso, o programa deve exibir o valor total das transações suspeitas e a quantidade de transações suspeitas.

Entrada
A entrada deve conter:
O valor limite para transações suspeitas.
O número de transações a serem analisadas.
Os valores das transações (valores inteiros ou decimais).

Saída
O programa deve exibir:
O valor total das transações que ultrapassam o limite.
O número de transações suspeitas.
Se nenhuma transação for suspeita, o programa deve exibir "Nenhuma transação suspeita".

Exemplos
A tabela abaixo apresenta exemplos com alguns dados de entrada e suas respectivas saídas esperadas.
Certifique-se de testar seu programa com esses exemplos e com outros casos possíveis.

Entrada 	Saída
500.00      Transacoes suspeitas: 1300.00
5           2 transacoes suspeitas
100.00
200.00
300.00
600.00
700.00

100.00      Transacoes suspeitas: 350.00
4           2 transacoes suspeitas
50.00
150.00
200.00
80.00

250.00      Transacoes suspeitas: 300.00
3           1 transacao suspeita
200.00
250.00
300.00
*/


using System;
using System.Collections.Generic;
using System.Linq;

// TODO: Crie a Classe AnalisadorDeTransacoes:
public class AnalisadorDeTransacoes
{
    public decimal Limite { get; set; }

    // TODO: Crie a lista para armazenar as transações realizadas:
    public List<decimal> Transacoes { get; set; }

    public AnalisadorDeTransacoes(decimal limite)
    {
        Limite = limite;
        Transacoes = new List<decimal>();
    }

    public void AdicionarTransacao(decimal valor)
    {
        Transacoes.Add(valor);
    }

    public List<decimal> ObterTransacoesSuspeitas()
    {
        // Retorne as transações que são superiores ao limite
        return Transacoes.Where(transacao => transacao > Limite).ToList();
    }

    public void ExibirRelatorio()
    {
        var suspeitas = ObterTransacoesSuspeitas();

        // TODO: Implemente a condição if para retornar uma mensagem informando que não há transações suspeitas:
        if (suspeitas.Count() == 0)
        {
            Console.WriteLine("Nenhuma transação suspeita");
        }
        else
        {
            decimal totalSuspeitas = suspeitas.Sum();
            int numeroSuspeitas = suspeitas.Count();

            string transacaoTexto =
                numeroSuspeitas == 1 ? "transacao suspeita" : "transacoes suspeitas";

            // TODO: imprima o total das transações suspeitas com duas casas decimais
            // e a quantidade de transações suspeitas
            Console.WriteLine($"Transacoes suspeitas: {totalSuspeitas:F2}");
            Console.WriteLine($"{numeroSuspeitas} {transacaoTexto}");
        }
    }
}

class Program
{
    static void Main()
    {
        decimal limite = decimal.Parse(Console.ReadLine());
        int quantidade = int.Parse(Console.ReadLine());

        var analisador = new AnalisadorDeTransacoes(limite);

        for (int i = 0; i < quantidade; i++)
        {
            decimal valor = decimal.Parse(Console.ReadLine());

            // TODO: adicione a transação à instância do analisador
            analisador.AdicionarTransacao(valor);
        }

        analisador.ExibirRelatorio();
    }
}
