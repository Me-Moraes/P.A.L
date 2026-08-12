algoritmo "Custo"
// Função :
// Autor :
// Data : 11/03/2026
// Seção de Declarações
var
   CF, IM, DI, cfi: real
inicio
      escreva ("digite o custo de fabricação: ")
      leia (CF)
      DI <- (CF*28)/100
      IM <- (CF*45)/100
      cfi <-  CF + IM + DI
      escreval ("o custo de produção foi:" ,CF , " com a adição do custo de distribuição em 28% o valor adicionado é:" ,DI , ", Mais a adição do imposto de 45% o valor adicionado é:" ,IM , ", logo o valor total fica:", cfi)
fimalgoritmo

