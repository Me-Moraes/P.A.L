algoritmo "semnome"
// Função :
// Autor :
// Data : 01/04/2026
// Seção de Declarações
var
   A1, A2: real
   N1, N2 : caracter
inicio
     escreva ("Digite o primeiro nome:")
     leia (N1)
     escreva ("Digite o segundo nome nome:")
     leia (N2)
     escreva ("Digite a altura da primeira pessoa: ")
     leia (A1)
     escreva ("Digite a altura da segunda pessoa: ")
     leia (A2)
     se (A1 > A2) entao
            escreva ("A pessoa mais alta é: ", N1 ," sendo sua altura de: ", A1)
        senao
            escreva ("A pessoa mais alta é: ", N2 ," sendo sua altura de: ", A2)
     fimse
fimalgoritmo
