'''Exercício Python 038: Escreva um programa que leia dois números inteiros e compare-os. mostrando na tela uma mensagem:
– O primeiro valor é maior
– O segundo valor é maior
– Não existe valor maior, os dois são iguais'''

numero_01 = int (input("Dígite o primeiro número inteiro: "))
numero_02 = int (input("Dígite o segundo número inteiro: "))
if numero_01 > numero_02:
    print(f"O primeiro número {numero_01} é maior que o segundo número {numero_02}")
elif numero_02 > numero_01:
    print(f"O segundo número {numero_02} é maior que o primeiro número {numero_01}")
else:
    print(f"O primeiro número {numero_01} é igual ao segundo número {numero_02}")