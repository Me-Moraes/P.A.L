using System.ComponentModel.Design;

double n1, m, q;
Console.WriteLine("Digite o número");
n1 = double.Parse(Console.ReadLine());
if (n1 > 0)
{
    m = n1 / 2;
    Console.WriteLine("A metade de " + n1 + " é " + m);
}
else
{
    q = Math.Pow(2, n1);
    Console.WriteLine("O quadrado de " + n1 + " é " + q);
}