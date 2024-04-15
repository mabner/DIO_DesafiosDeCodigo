"""
Desafio
Em um jogo de RPG, os personagens geralmente possuem uma lista de itens que podem ser 
utilizados durante o jogo. Esses itens podem ser armas, armaduras, poções de cura, entre outros.
É importante que o jogador tenha um controle desses itens para poder utilizá-los
no momento adequado.

Crie um programa que permita cadastrar uma lista de itens que o personagem possui.
A lista deve conter o valor fixo de 3 itens e deve ser exibida na tela.

Entrada
O programa deve solicitar ao usuário o nome dos 3 itens que o personagem possui.
Cada item deve ser cadastrado separadamente.

Saída
Após receber os itens cadastrados pelo usuário, o programa deve exibir na tela a
lista de itens que o personagem possui. A saída deve ter o seguinte formato:

Lista de itens:
- [item1]
- [item2]
- [item3]

Exemplos
A tabela abaixo apresenta exemplos com alguns dados de entrada e suas respectivas
saídas esperadas. Certifique-se de testar seu programa com esses exemplos e com
outros casos possíveis.

Entrada	Saída
----------------------
Espada
Escudo
Poção

Lista de itens:
- Espada
- Escudo
- Poção
----------------------
Gema
Flecha
Capa

Lista de itens:
- Gema
- Flecha
- Capa
----------------------
Masterball
Potion
Elixir

Lista de itens:
- Masterball
- Potion
- Elixir
"""
# Desafio: Lista de itens
# Lista para armazenar os itens
itens = []

# TODO: Solicite os itens ao usuário
for item_input in range (3):
    itens.append(input(""))

# Exibe a lista de itens
print("Lista de itens:")
for item in itens:
    print(f"- {item}")
