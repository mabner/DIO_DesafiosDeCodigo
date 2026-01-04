/*
-- Explorando Estruturas de Dados em .NET2 --
      -- Lista de Tarefas da IA .NET --

-= Desafio =-
A empresa DigitalBrains está implementando uma solução inovadora de Transformação Digital com .NET,
integrando Inteligência Artificial à gestão de tarefas do time. O sistema ainda está em protótipo e,
neste momento, a IA precisa de ajuda para processar uma lista de tarefas do dia eficientemente.

Cada tarefa é descrita por palavras separadas por espaços, recebidas como uma única linha de texto.
A IA.NET precisa reorganizar a lista de tarefas de modo que as tarefas realizadas (“feito”) sejam
movidas para o final da lista, preservando a ordem relativa das outras tarefas. Sua missão é implementar
esse algoritmo usando apenas listas, conforme o estágio do projeto. Outros métodos não são permitidos,
pois a equipe deseja validar a integração de estruturas de dados básicas.
Não utilize bibliotecas externas à linguagem.

-= Entrada =-
Uma única linha contendo os nomes das tarefas separadas por espaços. Cada tarefa é representada
por uma palavra em caracteres ASCII sem acentuação. Pelo menos uma tarefa será apresentada e
podem existir múltiplas ocorrências da palavra “feito”.

-= Saída =-
Uma única linha contendo os nomes das tarefas reorganizadas, separados por espaço,
de modo que todas as tarefas “feito” apareçam no final da lista, mantendo a ordem das demais tarefas.

-= Exemplos =-
A tabela abaixo apresenta exemplos de entrada e saída:
Entrada									Saída
email feito relatorio feito deploy 		email relatorio deploy feito feito
feito feito teste						teste feito feito
apresentacao design feito				apresentacao design feito
*/

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Lê uma linha contendo as tarefas separadas por espaço
        string input = Console.ReadLine();

        // Converte a entrada em uma lista de tarefas
        List<string> tarefas = new List<string>(input.Split(' '));

        // TODO: Separe as tarefas realizadas ("feito") das tarefas pendentes,
        //       mantendo a ordem relativa de ambas nas listas.
        List<string> tarefasPendentes = new List<string>();
        List<string> tarefasFeitas = new List<string>();
        
        // Dica: Percorra todas as tarefas e utilize duas listas diferentes.
        foreach (string tarefa in tarefas)
        {
          if (tarefa == "feito")
            tarefasFeitas.Add(tarefa);
          else
            tarefasPendentes.Add(tarefa);
        }
        
        // Após separar, coloque primeiro as pendentes e depois todas as "feito"
        List<string> resultado = new List<string>();
        resultado.AddRange(tarefasPendentes);
        resultado.AddRange(tarefasFeitas);

        // Imprime as tarefas reordenadas
        Console.WriteLine(string.Join(" ", resultado));
    }
}