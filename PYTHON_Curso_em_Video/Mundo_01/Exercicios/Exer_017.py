'''Faça um programa que leia o comprimento do cateto oposto e do cateto adjacente de um triângulo retângulo. Calcule e mostre o comprimento da hipotenusa.'''

from math import hypot
cateto_oposto = float(input("Dígite o cateto oposto de  umt triângulo retângulo: "))
cateto_adjacente = float(input("Dígite o cateto adjacente de um triângulo retângulo : "))
hipotenusa = hypot(cateto_oposto, cateto_adjacente)
print(f"O comprimento da hipotenusa é de: {hipotenusa:.2f}")