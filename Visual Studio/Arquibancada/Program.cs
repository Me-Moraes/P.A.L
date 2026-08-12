int npa;
Console.WriteLine("Digite o número de pessoas na arquibancada: ");
npa = int.Parse(Console.ReadLine());
if ((npa <= 100) && (npa >= 100))
{
    Console.WriteLine("A arquibancada está vazia");
}
else if ((npa >= 1001) && (npa <= 15000))
{
    Console.WriteLine("A arquibancada está média");
}
if (npa > 15000)
{
    Console.WriteLine("A arquibancada está lotada");
}