"""
-----------==== Exercite os Fundamentos sobre Python ====-----------
---- Caixa Inteligente: Cálculo de Preço com Promoção no Varejo ----

- Desafio -
No Núcleo de Pesquisa e Desenvolvimento da VarejoTech, você faz parte de
uma equipe responsável por criar soluções inovadoras para o setor de varejo.
Hoje, o desafio é automatizar a análise de produtos para uma nova linha de
caixas inteligentes. Cada produto recebe uma etiqueta com seu preço e uma
indicação se está em promoção. Seu sistema deve receber o preço do produto
e um código que indica se ele está em promoção ("S" para sim, "N" para não).
Se o produto estiver em promoção, o sistema deve aplicar um desconto de 10%
e informar o valor final. Caso contrário, o preço permanece o mesmo.
O objetivo é garantir que o caixa inteligente sempre mostre o valor correto
ao cliente, evitando erros e otimizando o atendimento.

Implemente um programa que leia o preço do produto (um número decimal positivo)
e o código de promoção (uma string "S" ou "N"), separados por espaço em uma única linha.
O programa deve calcular e exibir o valor final do produto, com duas casas decimais,
aplicando o desconto apenas se o código for "S". Considere apenas entradas válidas.

- Entrada -
Uma única linha contendo o preço do produto (número decimal positivo) e
o código de promoção ("S" ou "N"), separados por espaço.

- Saída -
Uma única linha contendo o valor final do produto, com duas casas decimais.

- Exemplos -
A tabela abaixo apresenta exemplos de entrada e saída:

Entrada         Saída
100.00 S	    90.00
59.90 N	        59.90
200.50 S	    180.45
10.00 N	        10.00
"""

# Leitura da entrada: preço e código de promoção
entrada = input().strip()
preco_str, codigo_promocao = entrada.split()

# Conversão do preço para float
preco = float(preco_str)

# TODO: Se o produto estiver em promoção ("S"), aplique 10% de desconto ao preço.
# Caso contrário, mantenha o preço original.
# Dica: Use uma estrutura condicional para decidir qual valor atribuir à variável preco_final.
# preco_final = ...
if codigo_promocao == "S":
    preco_final = preco * 0.90
else:
    preco_final = preco

# Exibe o valor final com duas casas decimais
print(f"{preco_final:.2f}")
