/*
 --== Modelando Estruturas com Objetos em JavaScript com Blip ==--
-- Como Identificar O Canal De Origem Em Mensagens De Chatbots --

-- Desafio-- 
Você foi contratado como desenvolvedor júnior em uma startup que está criando uma plataforma de
inteligência conversacional para automatizar conversas entre marcas e clientes em múltiplos canais digitais.
Seu primeiro desafio é ajudar a equipe a identificar rapidamente o canal de origem de cada mensagem recebida,
para que o sistema possa direcionar a conversa ao bot correto. Cada mensagem chega como um objeto contendo as
propriedades "canal" (com o nome do canal digital, como "whatsapp", "instagram", "webchat" ou "sms") e "texto"
(com o conteúdo da mensagem). Sua tarefa é criar uma função que, ao receber uma string JSON representando esse objeto,
retorne apenas o nome do canal em letras minúsculas. Se a propriedade "canal" não existir ou estiver vazia,
a função deve retornar "indefinido". Não utilize bibliotecas externas.

Implemente a lógica de extração do canal a partir do objeto recebido, garantindo que o sistema sempre saiba
de onde veio cada mensagem. Lembre-se de tratar corretamente casos em que a propriedade não está presente ou está vazia.

-- Entrada --
Uma única string no formato JSON representando um objeto com as propriedades "canal" e "texto".

-- Saída --
Uma única string contendo o nome do canal em letras minúsculas, ou "indefinido" caso a
propriedade "canal" não exista ou esteja vazia.

-- Exemplos-- 
A tabela abaixo apresenta exemplos de entrada e saída:

Entrada                                                 Saída
{"canal":"whatsapp","texto":"Oi, preciso de ajuda"}	    whatsapp
{"canal":"Instagram","texto":"Quero saber mais"}	    instagram
{"texto":"Mensagem sem canal"}	                        indefinido
{"canal":"","texto":"Teste de canal vazio"}	            indefinido
 */

// IMPORTANTE: As funções "gets" e "print" são acessíveis globalmente e têm as seguintes funcionalidades:
// - "gets": lê UMA linha com dados de entrada (inputs) do usuário;
// - "print": imprime um texto de saída (output) e pula uma linha ("\n") automaticamente;
// Use este template para começar o desafio.

// Lê a entrada JSON da mensagem
const entrada = gets();

// TODO: Analise a string JSON recebida e imprima o canal em letras minúsculas,
// ou "indefinido" caso a propriedade "canal" não exista ou esteja vazia.

function analisarEntrada(entrada) {
  const objetoMensagem = JSON.parse(entrada);

  if (objetoMensagem.canal && objetoMensagem.canal.trim() !== '') {
    print(objetoMensagem.canal.toLowerCase());
  } else {
    print('indefinido');
  }
}

analisarEntrada(entrada);
