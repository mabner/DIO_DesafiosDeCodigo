"""
-----------==== Exercite os Fundamentos sobre Python ====-----------
---- Produto Mais Popular: Identificando Tendências no Varejo ------

- Desafio -
No Núcleo de Pesquisa e Desenvolvimento da empresa VarejoFuturo,
você faz parte de uma equipe responsável por analisar tendências de
produtos para o setor varejista. Seu time recebe diariamente listas de
produtos sugeridos por diferentes especialistas, e precisa identificar
rapidamente quais produtos são mais populares para priorizar o desenvolvimento de novos serviços.

Para isso, você deve criar um programa que receba uma lista de nomes de
produtos (separados por espaço) e retorne o nome do produto mais frequente.
Caso haja empate, retorne o produto que aparece primeiro na lista original.
Sua solução será fundamental para acelerar as decisões do núcleo e garantir
que os produtos certos cheguem ao mercado!

Implemente um programa que leia uma linha contendo nomes de produtos separados por espaço.
O programa deve identificar qual produto aparece mais vezes na lista. Se houver empate,
retorne o que aparece primeiro na lista. Utilize apenas estruturas básicas como listas
e tuplas para resolver o problema.

- Entrada -
Uma única linha contendo nomes de produtos separados por espaço. Cada nome é uma string sem espaços internos.

- Saída -
Uma única string representando o nome do produto mais frequente na lista. Em caso de empate, retorne o que aparece primeiro.

- Exemplos -
A tabela abaixo apresenta exemplos de entrada e saída:

Entrada	                            Saída
cafe leite pao leite pao pao	    pao
arroz feijao arroz feijao	        arroz
banana maca pera	                banana
suco suco agua agua agua	        agua
"""
    
# Lê a linha de entrada e separa os produtos em uma lista
produtos = input().strip().split()

# TODO: Crie uma estrutura para contar quantas vezes cada produto aparece na lista
# set
contagem = {}

# Dica: Use um laço para percorrer a lista e atualizar a contagem de cada produto

# Inicialize variáveis para armazenar o produto mais frequente e sua contagem
mais_frequente = None
maior_contagem = -1

# Percorra a lista original para garantir o critério de desempate (primeira ocorrência)
for produto in produtos:
    # TODO: Obtenha a contagem do produto atual e atualize mais_frequente se necessário
    contagem[produto] = contagem.get(produto, 0) + 1
    if contagem[produto] > maior_contagem:
        mais_frequente = produto
        maior_contagem = contagem[produto]
# Imprima o produto mais frequente
print(mais_frequente)
