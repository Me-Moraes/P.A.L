string n, s;
double p, a;
Console.WriteLine("Escreva o nome da pessoa: ");
n = Console.ReadLine();
Console.WriteLine("Escreva o sexo da pessoa (m/f): ");
s = Console.ReadLine();
Console.WriteLine("Escreva a altura da pessoa: ");
a = double.Parse(Console.ReadLine());

if ((s == "f") || (s == "F"))
{
    p = (62.1 * a) - 44.7;
    Console.WriteLine("você é do sexo feminino sendo seu peso ideal " + p);
}
else if ((s == "m") || (s == "M"))
{
    p = (72.7 * a) - 58;
    Console.WriteLine("você é do sexo masculico sendo seu peso ideal " + p);
}
else
{
    Console.WriteLine("Sexo incorreto");
}