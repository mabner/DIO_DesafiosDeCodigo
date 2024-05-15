"""
Desafio
Você foi designado para desenvolver um programa para gerenciar os equipamentos de uma empresa.
O objetivo é criar um solução que permita aos usuários inserir informações sobre os equipamentos
que serão cadastrados na rede, em seguida, exibir essa lista de equipamentos. Crie uma Lista para
armazenar esses equipamentos e depois um loop para solicitar ao usuário inserir até três equipamentos.

Entrada
O programa solicitará ao usuário que insira uma lista com três equipamentos para adicionar a rede.

Saída
Após a entrada dos itens, o programa exibirá a lista de equipamentos inseridos pelo usuário.
Cada equipamento será listado com um prefixo ( - ) de marcação para melhor organização.

Exemplos
A tabela abaixo apresenta exemplos com alguns dados de entrada e suas respectivas saídas esperadas.
Certifique-se de testar seu programa com esses exemplos e com outros casos possíveis.

Entrada         Saída
Antena          Lista de Equipamentos:
Roteador        - Antena
Switch          - Roteador
                - Switch


Servidor        Lista de Equipamentos:
Cabinet Rack    - Servidor
Access Point    - Cabinet Rack
                - Access Point

Edge Routers    Lista de Equipamentos:
Patch Cord      - Edge Routers
UPS             - Patch Cord
                - UPS
"""

itens = []

for item_entrada in range(3):
    itens.append(input(""))

print("Lista de Equipamentos:")
for item in itens:

    print(f"- {item}")
