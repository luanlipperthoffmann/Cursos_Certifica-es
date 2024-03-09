'''Exercício Python 37: Escreva um programa em Python que leia um número inteiro qualquer e peça para o usuário escolher qual será a base de conversão: 1 para binário, 2 para octal e 3 para hexadecimal.'''
numero = int (input("Dígite um número inteiro: "))
base_conversão = int (input("Informe a bese de conversão: \n1 => BINÁRIO \n2 => OCTAL \n3 => HEXADECIMAL \n"))
if base_conversão == 1:
    print(f"O número {numero} em binário é: {bin(numero)[2:]}")
elif base_conversão == 2: 
    print(f"O número {numero} em octal é: {oct(numero)}")
elif base_conversão == 3: 
    print(f"O número {numero} em hexadecimal é: {hex(numero)}")
else:
    print(f"O número {base_conversão} dígitado não é uma base de conversão válida!")