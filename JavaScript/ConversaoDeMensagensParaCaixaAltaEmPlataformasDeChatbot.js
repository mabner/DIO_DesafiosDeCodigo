/*
        --== Dominando Funções em JavaScript com a Blip ==--
--- Conversão De Mensagens Para Caixa Alta Em Plataformas De Chatbot ---

-- Desafio --
Você foi contratado como desenvolvedor júnior em uma startup que está criando uma plataforma de
inteligência conversacional para automatizar conversas entre marcas e clientes em múltiplos canais digitais.
Seu primeiro desafio é ajudar a equipe a padronizar as mensagens automáticas enviadas aos usuários.
Para isso, você deve criar uma função que receba uma mensagem de entrada e retorne a mesma mensagem,
mas com todas as letras minúsculas convertidas para maiúsculas. Isso garantirá que as respostas automáticas
sejam sempre claras e padronizadas, independentemente de como o usuário escreveu. Sua solução deve ser implementada
como uma função simples, sem o uso de bibliotecas externas, e funcionar para qualquer mensagem composta
apenas por letras, números, espaços e sinais de pontuação comuns.

Implemente uma função que receba uma string representando a mensagem enviada por um usuário e retorne a mesma mensagem,
mas com todas as letras minúsculas convertidas para maiúsculas. Não altere números, espaços ou sinais de pontuação.
Considere que a entrada sempre será uma string não vazia.

-- Entrada --
Uma única linha contendo a mensagem enviada pelo usuário. A mensagem pode conter letras, números, espaços e sinais de pontuação comuns.

-- Saída --
Uma única linha contendo a mensagem convertida, com todas as letras minúsculas transformadas em maiúsculas.
Números, espaços e sinais de pontuação devem permanecer inalterados.

-- Exemplos --
A tabela abaixo apresenta exemplos de entrada e saída:

Entrada                         Saída
ola, tudo bem?                  OLA, TUDO BEM?
Bem-vindo ao chatBot123!	    BEM-VINDO AO CHATBOT123!
Como posso ajudar voce hoje?	COMO POSSO AJUDAR VOCE HOJE?
ok, obrigado!	                OK, OBRIGADO!
*/

// Lê a mensagem enviada pelo usuário
const mensagem = gets();

// TODO: Converta todas as letras minúsculas da mensagem para maiúsculas
// Dica: existe um método nativo de string para isso
function converterParaMaiusculo(mensagem) {
  return mensagem.toUpperCase();
}

let mensagemPadronizada = converterParaMaiusculo(mensagem);

// Imprima a mensagem padronizada
print(mensagemPadronizada);