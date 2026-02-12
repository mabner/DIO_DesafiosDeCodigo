/*
--== Entendendo Estrutura de Decisão e Repetição de JavaScript com a Blip ==--
        -- Contador De Mensagens Por Tipo Em Conversas Digitais --

- Desafio -
Em uma plataforma de inteligência conversacional, marcas automatizam diálogos com clientes
em múltiplos canais digitais, como chatbots, redes sociais e aplicativos de mensagens.
Para avaliar o comportamento desses robôs, a equipe de desenvolvimento precisa analisar
quantas mensagens de um determinado tipo aparecem em uma conversa simulada.

Seu desafio é implementar um programa que, dado o tipo de mensagem que se deseja analisar,
conte quantas mensagens desse tipo foram enviadas em um fluxo de conversa. Ao final,
o programa deve exibir apenas a quantidade total de mensagens encontradas daquele tipo, em formato numérico.

Cada mensagem da conversa é identificada por um prefixo no início da linha:
"BOT:" para mensagens automáticas do robô ou "USER:" para mensagens enviadas pelo cliente.
O tipo de mensagem a ser contado será informado antes da lista de mensagens.

Importante: embora a conversa possa conter mensagens dos dois tipos (BOT: e USER:),
o programa deve contar apenas as mensagens cujo prefixo corresponda ao tipo informado
na primeira linha da entrada, ignorando as demais.

Utilize estruturas de repetição para processar todas as mensagens até o final da conversa.
Não utilize bibliotecas externas.

- Entrada -
A primeira linha contém o tipo de mensagem a ser contado ("BOT" ou "USER").
As linhas seguintes contêm as mensagens trocadas, cada uma iniciando com "BOT:" ou "USER:".
A entrada termina quando for lida a linha "FIM", que indica o fim da conversa e não deve ser considerada na contagem.

- Saída -
Imprima um único número inteiro representando a quantidade de mensagens do tipo especificado encontradas na conversa.
Não imprima mensagens adicionais, apenas o número.

- Exemplos -
No primeiro exemplo, por exemplo, a conversa possui 3 mensagens (BOT: Hello, USER: Hi e BOT: How can I help?),
mas como o tipo a ser contado é BOT, apenas 2 delas são consideradas, resultando na saída 2.

Entrada                 Saída
BOT                     2
BOT: Hello
USER: Hi
BOT: How can I help?
FIM

USER                    2  
USER: Hi
BOT: Welcome
USER: Need help
FIM

BOT                     0
USER: Hello
USER: Info
FIM

USER                    0
BOT: Hi
BOT: Anything else?
FIM
*/

// Lê o tipo de mensagem a ser contado ("BOT" ou "USER")
const tipoMensagem = gets();
let contador = 0;

// TODO: Leia as mensagens até encontrar a linha "FIM"
while (true) {
  const mensagem = gets();
  if (mensagem === 'FIM') {
    break;
  }
  // TODO: Para cada mensagem, verifique se ela começa com o tipo desejado (por exemplo: "BOT:" ou "USER:")
  if (mensagem.startsWith(tipoMensagem + ':')) {
    // TODO: Se começar com o tipo desejado, aumente o contador em 1
    contador++;
  }
}

// Ao final, imprima a quantidade de mensagens do tipo escolhido
print(contador);
