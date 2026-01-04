/*
 -= Aplicando Conceitos de POO em C# =-
-= Digital Assistant: Saudação Inteligente =-

-= Desafio =-
Na vanguarda da transformação digital, uma equipe de desenvolvimento foi encarregada
de criar uma assistente virtual inteligente utilizando conceitos de
Programação Orientada a Objetos e a plataforma .NET. A primeira tarefa deste
projeto inovador é construir uma classe simples chamada Saudacao, que será usada
pelo sistema de Inteligência Artificial para cumprimentar os clientes de maneira
personalizada, sempre que eles acessam o portal digital da empresa.

Você deve implementar uma classe que receba o nome de um cliente e produza
uma mensagem de saudação padronizada. Ao receber o comando da IA com o nome
do cliente, o sistema deve imprimir exatamente: "Bem-vindo, [nome]!",
substituindo [nome] pelo valor informado na entrada.
Não adicione espaços extras antes ou depois do nome.

Use apenas recursos básicos da linguagem para implementar a classe,
seguindo os princípios de encapsulamento e uso de métodos.
Não utilize bibliotecas externas.

-= Entrada =-
Uma única string representando o nome do cliente, garantindo que
não contém espaços antes ou depois do nome.

-= Saída =-
Uma string contendo a saudação no seguinte formato: Bem-vindo, [nome]!

-= Exemplos =-
A tabela abaixo apresenta exemplos de entrada e saída:
Entrada     Saída
Lucas       Bem-vindo, Lucas!
AnaMaria    Bem-vindo, AnaMaria!
R2D2        Bem-vindo, R2D2!
*/

using System;

// Classe que deve gerar a saudação personalizada
public class Saudacao
{
    private readonly string nomeCliente;

    public Saudacao(string nomeCliente)
    {
        this.nomeCliente = nomeCliente;
    }

    public string ObterMensagem()
    {
        // TODO: Implemente a lógica para criar uma saudação personalizada usando o nome armazenado.
        // Dica: utilize interpolação de strings para incluir o nome na mensagem final.

        return $"Bem-vindo, {nomeCliente}!"; // Retorne a mensagem formatada corretamente aqui
    }
}

public class Program
{
    public static void Main()
    {
        // Entrada: lê o nome do cliente da entrada padrão
        string nome = Console.ReadLine();

        // Instancia a Saudacao passando o nome informado
        Saudacao s = new Saudacao(nome);

        // Saída: imprime a mensagem personalizada
        Console.WriteLine(s.ObterMensagem());
    }
}