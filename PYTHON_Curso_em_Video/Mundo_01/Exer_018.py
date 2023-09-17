#Faça um programa que leia um ângulo qualquer e mostre na tela o valor do seno, cosseno e tangente desse ângulo.

from math import radians, sin, cos, tan
angulo = float(input("Dígite o ângulo desejado: "))
print(f"O ângulo {angulo} possui:\n Um seno de: {sin(radians(angulo)):.2f} \n Um cosseno de : {cos(radians(angulo)):.2f}  \n Uma tangente de {tan(radians(angulo)):.2f}")