/*
--== Entendendo Estrutura de Decisão e Repetição de JavaScript com a Blip ==--
                 -- Bot Command Recognition Challenge --

- Desafio -
Na BotMakers Inc., uma empresa inovadora de criação de bots, você foi contratado para ajudar 
a equipe de desenvolvimento a testar o módulo de identificação de comandos.
Os bots recebem mensagens dos usuários e precisam responder corretamente de acordo com o comando enviado.
Cada mensagem pode ser um dos seguintes comandos: "start", "stop" ou "pause".
Se o comando não for reconhecido, o bot deve responder com "unknown command".
Sua tarefa é implementar a lógica de decisão que permite ao bot identificar o comando recebido e responder de acordo.

Implemente um programa que leia uma string representando o comando enviado ao bot
e imprima a resposta apropriada. Utilize estruturas condicionais para determinar a resposta correta.
Não utilize bibliotecas externas. O programa deve ser capaz de diferenciar entre os comandos válidos
e qualquer outro texto enviado.

- Entrada -
Uma única string representando o comando enviado ao bot. Os comandos válidos são "start", "stop" e "pause".
Qualquer outro valor deve ser tratado como comando desconhecido.

- Saída -
Imprima "Bot started" se o comando for "start", "Bot stopped" se for "stop", "Bot paused" se for "pause"
e "unknown command" para qualquer outro valor.

- Exemplos -
A tabela abaixo apresenta exemplos de entrada e saída:

Entrada     Saída
start       Bot started
stop        Bot stopped
pause       Bot paused
hello       unknown command
*/
// IMPORTANTE: As funções "gets" e "print" são acessíveis globalmente e têm as seguintes funcionalidades:
// - "gets": lê UMA linha com dados de entrada (inputs) do usuário;
// - "print": imprime um texto de saída (output) e pula uma linha ("\n") automaticamente;
// Use a estrutura abaixo para implementar a lógica do desafio.

const comando = gets(); // Lê o comando enviado ao bot

// TODO: Use estruturas condicionais para imprimir a resposta correta de acordo com o comando recebido
switch (comando) {
  case 'start':
    print('Bot started');
    break;
  case 'stop':
    print('Bot stopped');
    break;
  case 'pause':
    print('Bot paused');
    break;
  default:
    print('unknown command');
}
