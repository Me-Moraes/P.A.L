int a1, a2;
string n1, n2;
Console.WriteLine("Digite o nome do primeiro cliente:");
n1 = Console.ReadLine();
Console.WriteLine("Digite o nome do segundo cliente:");
n2 = Console.ReadLine();
Console.WriteLine("Digite o salário do primeiro cliente:");
a1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o salário do segundo cliente:");
a2 = int.Parse(Console.ReadLine());
if (a1 == a2)
{
    Console.WriteLine("O alario de" + n1 + " é igual a de" + n2);
}
else if (a1 > a2)
{
    Console.WriteLine("O alario de" + n1 + " é maior do que de" + n2);
}
else if (a1 < a2)
{
    Console.WriteLine("O alario de" + n2 + " é maior do que de" + n1);
}