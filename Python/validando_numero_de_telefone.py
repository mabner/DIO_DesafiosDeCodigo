"""
Desafio
Imagine que você trabalha para uma empresa de telecomunicações e é responsável por validar se
um número de telefone fornecido pelo cliente está em um formato correto. Para garantir a precisão
dos registros, é essencial que os números de telefone estejam no formato padrão. Desenvolva uma
função programa que valide se um número de telefone tem o formato correto.

Formato esperado:
O formato aceito para números de telefone é: (XX) 9XXXX-XXXX, onde X representa um dígito de 0 a 9.
Lembre-se de respeitar os espaços entre os números quando preciso.

Entrada
Uma string representando o número de telefone.

Saída
Uma mensagem indicando se o número de telefone é válido ou inválido.

Exemplos
A tabela abaixo apresenta exemplos com alguns dados de entrada e suas respectivas saídas esperadas.
Certifique-se de testar seu programa com esses exemplos e com outros casos possíveis.

Entrada	                Saída
(88) 98888-8888         Número de telefone válido.
(11)91111-1111	        Número de telefone inválido.
225555-555              Número de telefone inválido.
"""

# Conheça mais sobre o Regex: https://docs.python.org/pt-br/3.8/howto/regex.html
# Conheça mais sobre o 're' do python: https://docs.python.org/pt-br/3/library/re.html

# Módulo 're' que fornece operações com expressões regulares.
import re


def validate_numero_telefone(phone_number):

    pattern = re.compile(r"\(\d{2}\) 9\d{4}-\d{4}")
    # A função 're.match()' para verifica se o padrão definido corresponde ao número de telefone fornecido.
    # O 're.match()' retorna um objeto 'match' se houver correspondência no início da string, caso contrário, retorna 'None'.
    if re.match(pattern, phone_number):
        return "Número de telefone válido."
    else:
        return "Número de telefone inválido."


phone_number = input()

result = validate_numero_telefone(phone_number)

print(result)
