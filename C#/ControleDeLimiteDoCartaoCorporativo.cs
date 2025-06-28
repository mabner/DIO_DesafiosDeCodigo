/*
# Controle de Limite do Cartão Corporativo #
Descrição
Você está desenvolvendo um sistema de controle de despesas para cartões corporativos usados por funcionários.
Cada funcionário possui um limite mensal e pode fazer diversas transações. O sistema deve informar se
o funcionário está dentro do limite ou se ultrapassou o valor permitido.

Entrada
A entrada deve conter o limite do cartão (número decimal) e em seguida uma lista com os valores de cada transação feita no mês.
O primeiro valor representa o limite do cartão.
O segundo valor representa a quantidade de transações.
As próximas linhas contêm os valores das transações (uma por linha).

Saída
Deverá retornar o total gasto e uma mensagem indicando se o limite foi ultrapassado ou não.

Exemplos
A tabela abaixo apresenta exemplos com alguns dados de entrada e suas respectivas saídas esperadas.
Certifique-se de testar seu programa com esses exemplos e com outros casos possíveis.


Entrada            Saída
1000.00            Total gasto: 650.00
3                  Limite OK
200.00
300.00
150.00

800.00             Total gasto: 900.00
3                  Limite ultrapassado
400.00
200.00
300.00

500.00             Total gasto: 250.00
2                  Limite OK
100.00
150.00
 */

using System;
using System.Collections.Generic;
using System.Linq;


class CartaoCorporativo
{
    public decimal Limite { get; }
    public List<decimal> Transacoes { get; }

    public CartaoCorporativo(decimal limite)
    {
        Limite = limite;
        Transacoes = new List<decimal>();
    }

    public void AdicionarTransacao(decimal valor)
    {
        Transacoes.Add(valor);
    }

    public decimal CalcularTotal()
    {
        return Transacoes.Sum();
    }

    public bool UltrapassouLimite()
    {
        return CalcularTotal() > Limite;
    }

    public void ExibirResumo()
    {
        // TODO: imprima o total gasto com duas casas decimais
        // e uma mensagem informando se o limite foi ultrapassado ou não
        Console.WriteLine($"Total gasto: {CalcularTotal()}");
        if (UltrapassouLimite())
        {
          Console.WriteLine("Limite ultrapassado");
        }
        else
        {
          Console.WriteLine("Limite OK");
        }
    }
}

class Program
{
    static void Main()
    {
        decimal limite = decimal.Parse(Console.ReadLine());
        int quantidade = int.Parse(Console.ReadLine());

        var cartao = new CartaoCorporativo(limite);

        for (int i = 0; i < quantidade; i++)
        {
            decimal valor = decimal.Parse(Console.ReadLine());

            // TODO: adicione a transação à instância do cartão
            cartao.AdicionarTransacao(valor);
        }

        cartao.ExibirResumo();
    }
}