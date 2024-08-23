/*
Descrição
Você recebeu a tarefa de ajudar um cliente a otimizar a alocação de seus ativos financeiros.
Além de calcular a alocação proporcional ao valor de mercado, você deve considerar várias
restrições que o cliente impôs:

Cada ativo deve ter uma alocação mínima e máxima.
O valor total a ser investido deve ser respeitado.
O número de ativos alocados deve ser igual ao número de ativos fornecido.
Seu desafio é criar um programa que receba a lista de valores de mercado dos ativos, o valor total a ser investido,
e as restrições de alocação mínima e máxima para cada ativo. O programa deve então calcular a quantidade de dinheiro
que deve ser alocada em cada ativo, respeitando as restrições fornecidas.

Entrada
A entrada deve receber cinco strings, representando os seguintes valores:

Um número inteiro N representando o número de ativos.
N números reais representando os valores de mercado atuais de cada ativo.
Um número real representando o valor total a ser investido.
N números reais representando as alocações mínimas de cada ativo.
N números reais representando as alocações máximas de cada ativo.
Saída
A saída deve retornar N números reais, cada um representando a quantidade de dinheiro a ser alocada em cada ativo.
O valor deve ser proporcional ao valor de mercado do ativo em relação ao valor de mercado total de todos os ativos
e deve respeitar as restrições de alocação mínima e máxima. Os valores devem ser arredondados para duas casas decimais.

Exemplos
A tabela abaixo apresenta exemplos com alguns dados de entrada e suas respectivas saídas esperadas. Certifique-se de
testar seu programa com esses exemplos e com outros casos possíveis.

Entrada					Saída
2						250.00
10.00, 30.00			750.00
1000.00
200.00, 500.00
400.00, 800.00	


2						150.00
10.00, 30.00			200.00
800.00
30.00, 50.00
150.00, 200.00


2						300.00
20.00, 40.00			600.00
1000.00
150.00, 250.00
300.00, 600.00

*/

using System;

class Program
{
    static void Main()
    {
        // Recebe a entrada do número de ativos
        int N = int.Parse(Console.ReadLine());
        
        // Receben e divide os valores de mercado em um array de strings
        string[] valoresMercadoStr = Console.ReadLine().Split(',');
        
        double[] valoresMercado = Array.ConvertAll(valoresMercadoStr, double.Parse);
        
        // Recebe o valor total investido
        double valorTotalInvestido = double.Parse(Console.ReadLine());
        
        // Recebe e divide as alocações mínimas em um array de strings
        string[] alocacoesMinimasStr = Console.ReadLine().Split(',');
        
        double[] alocacoesMinimas = Array.ConvertAll(alocacoesMinimasStr, double.Parse);
        
        // Recebendo e dividindo as alocações máximas em um array de strings
        string[] alocacoesMaximasStr = Console.ReadLine().Split(',');
        
        double[] alocacoesMaximas = Array.ConvertAll(alocacoesMaximasStr, double.Parse);
        
        // Calcula o total do mercado
        double totalMercado = 0;
        for (int i = 0; i < N; i++)
        {
            // TODO: Some os valores de mercado para obter o total
            totalMercado += valoresMercado[i];
        }

        // Calcula as alocações proporcionais e ajustando aos limites mínimos e máximos
        double[] alocacoes = new double[N];
        for (int i = 0; i < N; i++)
        {
            // TODO: Calcule a alocação proporcional
            double proporcional = ( valorTotalInvestido / totalMercado ) * valoresMercado[i];
            
            alocacoes[i] = Math.Max(alocacoesMinimas[i], Math.Min(alocacoesMaximas[i], proporcional)); // Ajusta dentro dos limites mínimos e máximos
        }

        // Imprime as alocações formatadas com duas casas decimais
        for (int i = 0; i < N; i++)
        {
            Console.WriteLine($"{alocacoes[i]:F2}"); // Mostra cada alocação formatada com duas casas decimais
        }
    }
}