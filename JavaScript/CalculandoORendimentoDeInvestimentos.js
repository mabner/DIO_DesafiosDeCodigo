/*
Descrição
Você foi contratado por uma corretora de investimentos para criar um programa simples
que ajude os clientes a calcular o rendimento de seus investimentos.
O seu desafio é criar um programa que receba o valor inicial do investimento,
a taxa de juros anual e o número de anos que o dinheiro ficará investido, e
retorne o valor final do investimento ao término do período. Suponha que os
juros são compostos anualmente.

Considere a seguinte fórmula para calcular o valor final de um investimento
com juros compostos: A = P * (1 + r / 100)^n

Onde:
𝐴 é o valor final do investimento.
𝑃 é o valor inicial do investimento.
𝑟 é a taxa de juros anual (em porcentagem).
𝑛 é o número de anos que o dinheiro ficará investido.

Entrada
A entrada deve receber três strings representando os seguintes valores:

1. O valor inicial do investimento (um número decimal).
2. A taxa de juros anual (um número decimal representando a porcentagem).
3. O número de anos que o dinheiro ficará investido (um número inteiro).

Saída
A saída deverá retornar o valor final do investimento após o período especificado,
com duas casas decimais.

Exemplos
A tabela abaixo apresenta exemplos com alguns dados de entrada e suas respectivas saídas esperadas.
Certifique-se de testar seu programa com esses exemplos e com outros casos possíveis.

Entrada         Saída
1000.00         1628.89
5.0
10

1500.00         1869.27
4.5
5

2000.00         2533.54
3.0
8
*/

// Desafios JavaScript na DIO têm funções "gets" e "print" acessíveis globalmente:
//- "gets" : lê UMA linha com dado(s) de entrada (inputs) do usuário;
//- "print": imprime um texto de saída (output), pulando linha.

// Captura as entradas do usuário
let valorInicial = gets();
let taxaJurosAnual = gets();
let numeroAnos = gets();

// Converte os tipos das entradas
valorInicial = parseFloat(valorInicial);
taxaJurosAnual = parseFloat(taxaJurosAnual);
numeroAnos = parseInt(numeroAnos);

// Calcula o rendimento
let valorFinal = calcularRendimento(valorInicial, taxaJurosAnual, numeroAnos);

// Função para calcular o valor final do investimento com juros compostos
function calcularRendimento(valorInicial, taxaJurosAnual, numeroAnos) {
  // Converte a taxa de juros de porcentagem para decimal
  let taxaJurosDecimal = taxaJurosAnual / 100;

  // TODO: Calcule o valor final usando a fórmula dos juros compostos
  let valorFinal =
    valorInicial * Math.pow(1 + taxaJurosAnual / 100, numeroAnos);

  // Retorna o valor final arredondado para duas casas decimais
  return valorFinal.toFixed(2);
}

// Exibe o resultado
print(valorFinal);
