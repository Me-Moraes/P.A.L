int npa;
Console.WriteLine("Digite o número de pessoas no show: ");
npa = int.Parse(Console.ReadLine());
if (npa < 500)
{
    Console.WriteLine("publico baixo");
}
else if (npa == 500)
{
    Console.WriteLine("publico médio");
}
else if (npa > 500)
{
    Console.WriteLine("publico bom");
}