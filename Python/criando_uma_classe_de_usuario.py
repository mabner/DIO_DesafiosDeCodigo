"""
Desafio : Criando uma Classe de Usuário
Vamos criar uma classe chamada UsuarioTelefone para representar um usuário de telefone.
Você pode definir um método especial e depois aplicar conceitos de encapsulamento nos atributos
dentro da classe. Lembre-se que, cada usuário terá um nome, um número de telefone e um plano
associado, neste desafio, simulamos três planos, sendo: Plano Essencial Fibra,
Plano Prata Fibra e Plano Premium Fibra.

Entrada
Nome do usuário, número de telefone e plano.

Saída
Mensagem indicando que o usuário foi criado com sucesso.

Exemplos
A tabela abaixo apresenta exemplos com alguns dados de entrada e suas respectivas saídas esperadas.
Certifique-se de testar seu programa com esses exemplos e com outros casos possíveis.


Entrada                             Saída
Ana                                 Usuário Ana criado com sucesso.
(11) 91111-1111
Plano Essencial Fibra

Sofia                               Usuário Sofia criado com sucesso.
(22) 92222-2222
Plano Prata Fibra

Pedro                               Usuário Pedro criado com sucesso.
(33) 93333-3333
Plano Premium Fibra
"""


class UsuarioTelefone():
    def __init__(self, nome, numero, plano):
        self._nome = nome
        self._numero = numero
        self._plano = plano

    def __str__(self):
        return f"Usuário {self._nome} criado com sucesso."


# Entrada:
nome = input()
numero = input()
plano = input()

usuario = UsuarioTelefone(nome, numero, plano)

print(usuario)
