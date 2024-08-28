/*
Descrição
Desenvolva uma função que calcula o rendimento de um portfólio com dividendos,
considerando os preços de compra e os dividendos recebidos. Este cálculo é essencial
para investidores que desejam entender o retorno real de seus investimentos,
incluindo não apenas o ganho de capital, mas também os pagamentos de dividendos.
A função permitirá uma análise mais precisa da performance do portfólio.

Considere a seguinte fórmula para calcular o rendimento:
Rendimento (%) = (Dividendos Totais / Preco Total de Compra) * 100.

Entrada
A entrada deve receber duas strings representando:

1. Uma lista com os preços de compra dos ativos,
separados por vírgula e espaço (, ).

2. Uma lista com os dividendos recebidos de cada ativo,
separados por vírgula e espaço (, ).

Cada índice nos arrays corresponde ao mesmo ativo. Por exemplo, o primeiro
valor no array de preços de compra corresponde ao preço de compra do mesmo
ativo que o primeiro valor no array de dividendos recebidos.

Saída
A função deverá retornar o rendimento total do portfólio em porcentagem com
duas casas decimais.

Exemplos
A tabela abaixo apresenta exemplos com alguns dados de entrada e suas
respectivas saídas esperadas. Certifique-se de testar seu programa com
esses exemplos e com outros casos possíveis.

Entrada             Saída
100, 200, 150       5.11%
5, 10, 8	
50, 100, 75         4.44%
2, 5, 3	
120, 220, 180       5.38%
6, 12, 10	
*/


// Lê os preços de compra dos ativos
let precosEntrada = gets();

// Lê os dividendos recebidos de cada ativo
let dividendosEntrada = gets();

// Separa e converte os preços de compra em um array de números
let precosCompra = precosEntrada.split(", ").map(Number);

// Separa e converte os dividendos recebidos em um array de números
let dividendosRecebidos = dividendosEntrada.split(", ").map(Number);

// Calcula o rendimento total do portfólio
let rendimento = calcularRendimento(precosCompra, dividendosRecebidos);

function calcularRendimento(precosCompra, dividendosRecebidos) {
  // Calcula o total de dividendos recebidos
  let dividendosTotais = 0;
  for (let dividendo of dividendosRecebidos) {
    dividendosTotais += dividendo;
  }

  // Calcula o preço total de compra dos ativos
  let precoTotalCompra = 0;
  for (let preco of precosCompra) {
    // TODO: Some cada preço de compra ao total
    precoTotalCompra += preco;
  }

  // TODO: Calcule o rendimento percentual
  let rendimento = (dividendosTotais / precoTotalCompra) * 100;

  return rendimento; // Retorna o rendimento calculado
}

// Exibir o resultado formatado com duas casas decimais
print(rendimento.toFixed(2) + "%");
