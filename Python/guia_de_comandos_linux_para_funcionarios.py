"""
--== Treinando Comandos de Linux com Python ==--
-- Guia De Comandos Linux Para Funcionários --

- Desafio -
Na loja de roupas "Fashion Terminal", a equipe utiliza um sistema Linux para organizar
o estoque e registrar vendas. Certo dia, a gerente percebeu que muitos funcionários
têm dúvidas sobre comandos básicos do terminal, especialmente ao listar arquivos
de diferentes departamentos. Para ajudar no treinamento, ela decidiu criar um simulador
que recebe o nome de um comando Linux e retorna sua descrição funcional, facilitando
o aprendizado dos colaboradores. Sua tarefa é implementar um programa que, ao receber
o nome de um comando Linux comum, retorne uma breve explicação sobre sua utilidade.
Caso o comando não seja reconhecido, o programa deve informar que o comando é invalido.

Implemente um programa que leia uma string representando o nome de um comando Linux
e imprima a descrição correspondente. Os comandos reconhecidos são:
ls (lista arquivos e diretorios), cd (altera o diretorio atual),
pwd (mostra o caminho do diretorio atual)
e mkdir (cria um novo diretorio).
Para qualquer outro comando, imprima "comando invalido". Não utilize bibliotecas externas.

- Entrada -
Uma única string representando o nome de um comando Linux.

- Saída -
Uma única string com a descrição do comando, ou "comando invalido" caso não seja reconhecido.

- Exemplos -
A tabela abaixo apresenta exemplos de entrada e saída:

Entrada     Saída
ls          lista arquivos e diretorios
cd	        altera o diretorio atual
pwd	        mostra o caminho do diretorio atual
rm	        comando invalido
"""

# Adicione no dicionário com comandos Linux e suas descrições
comandos = {
    "ls": "lista arquivos e diretorios",
    "cd": "altera o diretorio atual",
    "pwd": "mostra o caminho do diretorio atual",
    "mkdir": "cria um novo diretorio"
}

# Lê o comando digitado pelo usuário
entrada = input().strip()

# Busca a descrição do comando ou informa se é inválido
descricao = comandos.get(entrada, "comando invalido")
print(descricao)