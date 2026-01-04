
/*
---= Aplicando Conceitos de POO em C# =----
--= ChatBot.NET: Mensagem Inteligente =--

-= Desafio =-
No laboratório da empresa VisionTech, você foi convidado a aprimorar o
ChatBot.NET — um sistema desenvolvido para interações inteligentes com
clientes em portais digitais. O projeto faz parte da transformação digital da empresa,
que aposta na união de .NET e Inteligência Artificial para automatizar
e personalizar o atendimento.

Seu papel é criar uma classe chamada Mensagem, que armazene uma saudação
enviada pelo cliente. Essa classe deve possuir um método chamado responder,
que recebe uma frase de saudação e retorna uma resposta automática formatada
pelo bot no seguinte padrão:

Formato: "BOT: Obrigado pela mensagem: [frase_recebida]"

Implemente a classe conforme a descrição e use-a para processar a saudação 
recebida na entrada, imprimindo a resposta gerada pelo método responder.

-= Entrada =-
Uma linha contendo uma frase (string) enviada pelo cliente via ChatBot.NET.

-= Saída =-
Uma linha contendo a resposta automática gerada pelo método responder seguindo
o padrão especificado.

-= Exemplos =-
A tabela abaixo apresenta exemplos de entrada e saída:

Entrada                     Saída
Hello, I need some help     BOT: Obrigado pela mensagem: Hello, I need some help
Good morning                BOT: Obrigado pela mensagem: Good morning
Support needed asap         BOT: Obrigado pela mensagem: Support needed asap
*/

using System;

namespace ChatBotNET
{
    // Classe responsável por armazenar e responder mensagens de saudação
    class Mensagem
    {
        private string saudacao;

        public Mensagem(string saudacao)
        {
            this.saudacao = saudacao;
        }

        // TODO: Modifique este método para personalizar a resposta do bot de acordo com critérios fornecidos pelo enunciado
        // Dica: avalie o conteúdo da saudação para determinar a resposta adequada

        public string responder()
        {
            // Atualmente, apenas retorna um padrão fixo. 
            // O aluno deve alterar para adaptar às regras do desafio.
            return $"BOT: Obrigado pela mensagem: {saudacao}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Lê a frase enviada pelo cliente via stdin
            string entrada = Console.ReadLine();

            // Instancia a classe Mensagem para processar a entrada
            Mensagem mensagem = new Mensagem(entrada);

            // Imprime a resposta do bot no formato especificado
            Console.WriteLine(mensagem.responder());
        }
    }
}