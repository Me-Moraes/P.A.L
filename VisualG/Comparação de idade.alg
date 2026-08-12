algoritmo "Comparação de idade"
// Função :
// Autor :
// Data : 01/04/2026
// Seção de Declarações
var
   I1, I2: real
   N1, N2 : caracter
inicio
     escreva ("Digite o primeiro nome:")
     leia (N1)
     escreva ("Digite o segundo nome nome:")
     leia (N2)
     escreva ("Digite a idade da primeira pessoa: ")
     leia (I1)
     escreva ("Digite a idade da segunda pessoa: ")
     leia (I2)
     se (I1 > I2) entao
            escreva ("A pessoa mais velha é: ", N1 ," sendo sua idade de: ", I1)
        senao
            escreva ("A pessoa mais velha é: ", N2 ," sendo sua idade de: ", I2)
     fimse
fimalgoritmo
