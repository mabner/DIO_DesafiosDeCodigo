/**
--== Modelando Estruturas com Objetos em JavaScript com Blip ==--
      -- Conversão De Mensagem Para Objeto Em Chatbot --

-- Desafio --
Em um ambiente de inteligência conversacional, marcas inovadoras utilizam robôs de atendimento para interagir
com clientes em múltiplos canais digitais. Você faz parte da equipe de tecnologia responsável por garantir
que as mensagens automáticas estejam sempre personalizadas e corretas. Para isso, cada mensagem enviada
pelo robô deve ser registrada em um objeto contendo o nome do cliente e o texto da mensagem.
Sua tarefa é criar uma função que, ao receber uma string no formato "nome:mensagem", construa um objeto
com as propriedades "cliente" e "texto", e retorne uma resposta formatada como "Para [cliente]: [texto]".
Se a entrada não contiver o caractere ":", a resposta deve ser "Formato invalido".

Implemente a lógica utilizando estruturas com objetos, sem bibliotecas externas. O programa deve processar
apenas uma linha de entrada por execução.

-- Entrada --
Uma única string no formato "nome:mensagem", onde "nome" e "mensagem" são sequências de caracteres sem
o caractere ":". Caso a string não contenha ":", considere a entrada inválida.

-- Saída --
Uma string formatada como "Para [cliente]: [texto]", onde [cliente] é o nome extraído antes do ":", e [texto] é
a mensagem após o ":". Se a entrada for inválida, imprima "Formato invalido".

-- Exemplos --
A tabela abaixo apresenta exemplos de entrada e saída:

Entrada                             Saída
Lucas:Seu pedido foi enviado	    Para Lucas: Seu pedido foi enviado
Ana:Bem vinda ao nosso canal	    Para Ana: Bem vinda ao nosso canal
Mensagem sem separador	            Formato invalido
Joao:Desconto exclusivo para voce	Para Joao: Desconto exclusivo para voce
 */

// Lê a entrada do usuário
const entrada = gets();

// TODO: Verifique se a entrada contém ":" e, se sim, separe o nome e a mensagem em variáveis distintas

// Dica: Use split para dividir a string e, se for válido, crie um objeto com as propriedades "cliente" e "texto".
// Imprima a resposta formatada conforme o exemplo ou "Formato invalido" se não houver ":".

function processarEntrada(entrada) {
  if (!entrada.includes(':')) {
    return 'Formato invalido';
  } else {
    let dados = entrada.split(':');
    let dadosObjeto = { cliente: dados[0], texto: dados[1] };

    return `Para ${dadosObjeto.cliente}: ${dadosObjeto.texto}`;
  }
}

print(processarEntrada(entrada));
