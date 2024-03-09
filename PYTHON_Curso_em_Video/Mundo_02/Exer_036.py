'''Exercício Python 36: Escreva um programa para aprovar o empréstimo bancário para a compra de uma casa. Pergunte o valor da casa, o salário do comprador e em quantos anos ele vai pagar. A prestação mensal não pode exceder 30% do salário ou então o empréstimo será negado.'''

valor_casa = float (input("Dígite o valor da casa R$"))
salario_comprador = float (input("Informe o sálario do comprador da casa R$"))
prestacao_anos = int (input("Informe em quantos será pago o empréstimo: "))
prestacao_mensal = (valor_casa/prestacao_anos)/12
execo_salario = salario_comprador*0.3
if prestacao_mensal <= execo_salario:
    print(f"A sua prestação mensal será de R${prestacao_mensal:.2f} \nEMPRESTIMO APROVADO")
else:
    print(f"A sua prestação mensal será de R${prestacao_mensal:.2f} \nEMPRESTIMO NEGADO")