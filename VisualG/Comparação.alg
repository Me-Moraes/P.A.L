algoritmo "Comparação"
// Função :
// Autor :
// Data : 01/04/2026
// Seção de Declarações
var
   N1, r1, r2 : Real
inicio
     escreva ("Digite o número:")
     leia (N1)
     se (N1 >= 0.1) entao
            r1 <- N1/2
            escreva ("A metade de: ", N1 ," é: ", r1)
        senao
            r2 <- N1*N1

            escreva ("O quadruplo de: ", N1 ," é: ", r2)
     fimse
fimalgoritmo
