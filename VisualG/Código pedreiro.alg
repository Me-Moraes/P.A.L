algoritmo "Código pedreiro"
// Função :
// Autor :
// Data : 11/03/2026
// Seção de Declarações
var
   qa, pea, ara, pep, arp, aa, ba, ap, bp: Real
inicio
      escreva ("digite o lado A do azulejo: ")
      leia (aa)
      escreva ("digite o lado B do azulejo: ")
      leia (ba)
      escreva ("digite o lado A da parede: ")
      leia (ap)
      escreva ("digite o lado B da parede: ")
      leia (bp)
      ara <- aa*ba
      pea <- aa*2 + ba*2
      arp <- ap*bp
      pep <- ap*2 + bp*2
      qa  <- pep/pea
      escreva ("a quantidade necessária para azulejar toda a parede é", qa)
fimalgoritmo
