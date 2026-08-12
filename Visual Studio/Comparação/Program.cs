double n1, n2, r, r2;
Console.WriteLine("Digite o primeiro número");
n1 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo número");
n2 = double.Parse(Console.ReadLine());
r = n1 * n2;
if (r > 10)
{
    r2 = Math.Pow(r, 2);
    Console.WriteLine("O resultado da multiplicação é maior a 10, elevando o resultado ao quadrado temos: " + r);
}
else if (r < 10)
{
    Console.WriteLine("O resultado da multiplicação é menor a 10, sendo o resultado: " + r);
}
