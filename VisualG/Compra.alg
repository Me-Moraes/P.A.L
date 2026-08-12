algoritmo "Compra"
// Função :
// Autor :
// Data : 04/03/2026
// Seção de Declarações
var
   QC, QM, QE: inteiro
   P: Caracter
inicio
escreva ("Digite o nome do produto: ")
leia(P)
escreva ("Digite a quantidade máxima: ")
leia(QM)
Escreva("Digite a quantidade em estoque: ")
Leia(QE)
QC <- QM - QE
Escreva("será necessáriao comprar: ",  QC , ", de ", P)
fimalgoritmo
