string n1, n2;
double p1, p2;
Console.WriteLine("Escreva o nome da primeira pessoa");
n1 = Console.ReadLine();
Console.WriteLine("Escreva o nome da segunda pessoa");
n2 = Console.ReadLine();
Console.WriteLine("Digite o peso da primeira pessoa");
p1 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o peso da segunda pessoa");
p2 = double.Parse(Console.ReadLine());
if (p1 > p2)
{
    Console.WriteLine(n1 + " é mais pesado(a) que " + n2 + " com " + p1 + " Kg");
}
else
{
    Console.WriteLine(n2 + " é mais pesado(a) que " + n1 + " com " + p2 + " Kg");
}