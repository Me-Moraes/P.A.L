algoritmo "Peso"
// Função :
// Autor :
// Data : 25/03/2026
// Seção de Declarações
var
    p1, p2: real
    n1, n2 : caracter
inicio
      escreva("Digite o primeiro nome: ")
      leia (n1)
      escreva("Digite o segundo nome: ")
      leia (n2)
      escreva("Digite o primeiro peso: ")
      leia (p1)
      escreva("Digite o segundo peso: ")
      leia (p2)
se (p1 > p2) entao
escreva (n1 " mais pesado(a) que ", n2)
      senao
      se (p1 < p2) entao
escreva (n1 ," mais leve que ", n2)
      senao
escreva (n1 ," igual a ", n2)
      fimse
      fimse
fimalgoritmo
