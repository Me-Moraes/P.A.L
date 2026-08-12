string n1, n2;
int i1, i2;
Console.WriteLine("Escreva o nome da primeira pessoa");
n1 = Console.ReadLine();
Console.WriteLine("Escreva o nome da segunda pessoa");
n2 = Console.ReadLine();
Console.WriteLine("Escreva a idade da primeira pessoa");
i1 = int.Parse(Console.ReadLine());
Console.WriteLine("Escreva a idade da segunda pessoa");
i2 = int.Parse (Console.ReadLine());
if (i1 > i2)
{
    Console.WriteLine(n1 + " é mais velho(a), com " + i1 + " anos");
}
else
{
    Console.WriteLine(n2 + " é mais velho(a), com " + i2 + " anos");
}