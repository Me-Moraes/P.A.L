algoritmo "Percentual de votos"
// Função :
// Autor :
// Data : 11/03/2026
// Seção de Declarações
var
   TE, PF1, PF2, T1, T2: real
inicio
      escreva ("digite a quantidade de votos na faixa 1: ")
      leia (T1)
      escreva ("digite a quantidade de votos na faixa 2: ")
      leia (T2)
      TE <-  T1 + T2
      PF1 <- (T1*100)/TE
      PF2 <- (T2*100)/TE
      escreval ("em relaçao ao número de eleitores (", TE, " ) ", "o percentual de votos na faixa 1 foi: ", PF1, "%")
      escreval ("em relaçao ao número de eleitores (", TE, " ) ", "o percentual de votos na faixa 2 foi: ", PF2, "%")
fimalgoritmo

