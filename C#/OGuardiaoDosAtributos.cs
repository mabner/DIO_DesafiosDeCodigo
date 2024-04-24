/*
Desafio
Em jogos de RPG, os personagens possuem atributos que determinam suas habilidades em diferentes áreas, como força, agilidade, inteligência, etc.
Neste desafio, você deve criar uma função que verifica se o valor de um determinado atributo está dentro de um intervalo aceitável.

Crie uma função chamada "verificar_atributo" que recebe três parâmetros: "atributo", "valor_minimo" e "valor_maximo". A função deve verificar se
o valor do atributo está dentro do intervalo definido pelos valores mínimo e máximo.
Caso o valor esteja dentro do intervalo, a função deve retornar true. Caso contrário, deve retornar false.

Entrada:
A entrada do código deverá ser feita através do io.stream(). Serão necessários três valores para chamar a função "verificar_atributo", que são:
o nome do atributo, o valor mínimo aceitável e o valor máximo aceitável. Além disso, também será necessário informar o valor atual do atributo que se deseja verificar.

Saída:
A saída do código será uma mensagem informando se o valor do atributo está dentro ou fora do intervalo especificado. Caso o valor esteja dentro do
intervalo, a mensagem será "O valor do atributo está dentro do intervalo especificado". Caso contrário, a mensagem será "O valor do atributo está
fora do intervalo especificado".

Exemplos
A tabela abaixo apresenta exemplos com alguns dados de entrada e suas respectivas saídas esperadas. Certifique-se de testar seu programa com esses
exemplos e com outros casos possíveis.

Entrada	Saída
força           O valor do atributo está dentro do intervalo especificado
1
10
7

destreza        O valor do atributo está fora do intervalo especificado   
6
12
3

inteligencia    O valor do atributo está dentro do intervalo especificado
1
100
94
*/

using System;

class Program
{
    static bool VerificarAtributo(string atributo, int valorMinimo, int valorMaximo, int valorAtributo)
    {
        return (valorAtributo >= valorMinimo && valorAtributo <= valorMaximo) ? true : false;
    }

    static void Main(string[] args)
    {
        string atributo = Console.ReadLine();

        int valorMinimo = int.Parse(Console.ReadLine());

        int valorMaximo = int.Parse(Console.ReadLine());

        int valorAtributo = int.Parse(Console.ReadLine());

        Console.WriteLine(VerificarAtributo(atributo, valorMinimo, valorMaximo, valorAtributo) ? "O valor do atributo está dentro do intervalo especificado" : "O valor do atributo está fora do intervalo especificado");
    }
}