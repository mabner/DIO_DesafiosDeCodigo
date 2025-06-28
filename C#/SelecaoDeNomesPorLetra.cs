
/*
# Seleção de Nomes por Letra #

Descrição
Uma empresa está desenvolvendo um sistema para triagem de candidatos.
O objetivo é filtrar nomes que comecem com uma letra específica informada.
Você deve implementar um algoritmo que receba uma lista de nomes em uma única
linha (separados por vírgula) e uma letra, e retorne apenas os nomes que começam com essa letra.

Entrada
A entrada deve conter:
Uma linha com os nomes separados por vírgula e espaço (ex: Ana, Pedro, Amanda)
Uma linha com a letra usada como filtro

Saída
O programa deve exibir os nomes que começam com a letra fornecida. Se nenhum nome corresponder,
exibir "Nenhum nome encontrado".

Exemplos
A tabela abaixo apresenta exemplos com alguns dados de entrada e suas respectivas saídas esperadas.
Certifique-se de testar seu programa com esses exemplos e com outros casos possíveis.

Entrada                                 Saída
Ana, Pedro, Amanda, Joao                Ana
A                                       Amanda

Lucas, Pedro, Lara, Leo, Samuel         Lucas
L                                       Lara
                                        Leo

Carla, Bruno, Paula                     Nenhum nome encontrado
J
*/


using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<string> filtrados = new List<string>();
        string linhaDeNomes = Console.ReadLine();

        // Separa os nomes e remove espaços extras
        List<string> nomes = linhaDeNomes
            .Split(',')
            .Select(nome => nome.Trim())
            .ToList();

        char letraFiltro = char.Parse(Console.ReadLine());

        // TODO: Filtre a lista de nomes que começam com a letra (ignore maiúsculas/minúsculas):
        foreach (string nome in nomes)
        {
          if (nome[0] == letraFiltro)
          {
            filtrados.Add(nome);
          }

        }

        // TODO: Retorne o resultado e implemente a condição if para retornar 'Nenhum nome encontrado' e exiba o resultado:
        if (filtrados.Count == 0)
        {
            Console.WriteLine("Nenhum nome encontrado");
        }
        else
        {
            foreach (var nome in filtrados)
            {
                Console.WriteLine(nome);
            }
        }
    }
}