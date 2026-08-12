algoritmo "Percentual de votos"
// Função :
// Autor :
// Data : 11/03/2026
// Seção de Declarações
var
   TE, VN, VB, VV, T1, T2,T3: real
inicio
      escreva ("digite a quantidade total de eleitores: ")
      leia (TE)
      escreva ("digite a quantidade de votos nulos: ")
      leia (VN)
      escreva ("digite a quantidade de votos em branco: ")
      leia (VB)
      escreva ("digite a quantidade de votos válidos: ")
      leia (VV)
      T1 <- (VN*100)/TE
      T2 <- (VB*100)/TE
      T3 <- (VV*100)/TE
      escreval ("em relaçao ao número de eleitores (", TE, " ) ", "a quantidade de votos validos foi: ", T3, "%")
      escreval ("em relaçao ao número de eleitores (", TE, " ) ", "a quantidade de votos em branco foi: ", T2, "%")
      escreval ("em relaçao ao número de eleitores (", TE, " ) ", "a quantidade de votos nulos foi: ", T1, "%")
fimalgoritmo
