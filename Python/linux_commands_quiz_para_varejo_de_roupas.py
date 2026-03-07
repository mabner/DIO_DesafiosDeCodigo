"""
--== Treinando Comandos de Linux com Python ==--
-- Linux Commands Quiz Para Varejo De Roupas --

- Desafio -
Na loja de roupas FastWear, a equipe de vendas utiliza terminais Linux para
registrar operações do estoque. Recentemente, a gerente percebeu que muitos
funcionários têm dúvidas sobre comandos básicos do sistema, o que atrasa o
atendimento e a reposição de produtos. Para resolver esse problema,
ela decidiu criar um treinamento prático: cada funcionário deve identificar
corretamente o comando Linux apropriado para uma determinada tarefa do dia a dia
na loja, como listar arquivos, criar diretórios para novas coleções ou
remover itens antigos do estoque digital. Sua missão é ajudar a gerente a
automatizar esse treinamento, criando um programa que, ao receber uma
descrição da tarefa, retorne o comando Linux correspondente.

Implemente um programa que leia uma string descrevendo uma tarefa comum em
um terminal Linux na loja e retorne o comando Linux mais adequado para realizá-la.
Considere apenas tarefas básicas como listar arquivos, criar diretórios,
remover arquivos e exibir o conteúdo de arquivos. Se a tarefa não corresponder
a nenhuma dessas, retorne "comando desconhecido". Não utilize bibliotecas externas.

- Entrada -
Uma única linha contendo a descrição da tarefa a ser realizada no terminal Linux.

- Saída -
Uma única linha com o comando Linux correspondente à tarefa ou "comando desconhecido" se não houver correspondência.

- Exemplos -
A tabela abaixo apresenta exemplos de entrada e saída:

Entrada	                                    Saída
listar arquivos do estoque	                ls
criar nova pasta para promocoes	            mkdir
remover arquivo antigo	                    rm
mostrar conteudo do arquivo vendas.txt      cat
atualizar sistema	                        comando desconhecido
"""

# Adicione os comandos que presentão as ordem solicitadas 
comandos = {
    "listar arquivos": "ls",
    "criar nova pasta": "mkdir",
    "remover arquivo": "rm",
    "mostrar conteudo": "cat"
}

descricao = input().strip().lower()

comando_encontrado = "comando desconhecido"
for chave, comando in comandos.items():
    if chave in descricao:
        comando_encontrado = comando
        break  # Encontrou o comando, não precisa continuar

print(comando_encontrado)