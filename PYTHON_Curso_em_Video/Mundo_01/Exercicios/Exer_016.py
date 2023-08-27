# Crie um programa que leia um número Real qualquer pelo teclado e mostre na tela a sua porção Inteira

from math import trunc
numero = float(input("Dígite em número: \n"))
print(f"O valor dígitado foi de {numero} e a sua porção inteira é de: {trunc(numero)}")