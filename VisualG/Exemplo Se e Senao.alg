algoritmo "Exemplo Se e senao"
// Função :
// Autor :
// Data : 25/03/2026
// Seção de Declarações 
var
     n1, n2, media: real
inicio
escreva("Digite a primeira nota: ")
      leia (n1)
           escreva("Digite a segunda nota: ")
                      leia (n2)
                media <- (n1 + n2)/2
      escreva ("a média do aluno é:", media)
se (media >= 7) entao
      escreva (" aluno aprovado")
      senao
      se ( (media >=5) e (media <=6.9) ) entao
      escreva (" Aluno de recuperação")
      senao
escreva (" Aluno reprovado")
      fimse
      fimse
fimalgoritmo
