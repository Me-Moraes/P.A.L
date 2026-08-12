algoritmo "semnome"
// Função :
// Autor :
// Data : 01/04/2026
// Seção de Declarações 
var
   N1A1, N2A1, N3A1, N1A2, N2A2, N3A2, M1, M2: real
   N1, N2 : caracter
inicio
     escreva ("Digite o primeiro nome:")
     leia (N1)
     escreva ("Digite o segundo nome nome:")
     leia (N2)
     escreva ("Digite a primeira nota do primeiro aluno: ")
     leia (N1A1)
     escreva ("Digite a segunda nota do primeiro aluno: ")
     leia (N2A1)
     escreva ("Digite a terceira nota do primeiro aluno: ")
     leia (N3A1)
     escreva ("Digite a primeira nota do segundo aluno: ")
     leia (N1A2)
     escreva ("Digite a segunda nota do segundo aluno: ")
     leia (N2A2)
     escreva ("Digite a terceira nota do segundo aluno: ")
     leia (N3A2)
     M1 <- (N1A1+N2A1+N3A1)/3
     M2 <- (N1A2+N2A2+N3A2)/3
     se (M1 > M2) entao
            escreva ("A maior nota é: ", M1 ," conquistada pelo aluno: ", N1)
        senao
             escreva ("A maior nota é: ", M2 ," conquistada pelo aluno: ", N2)
     fimse
fimalgoritmo
