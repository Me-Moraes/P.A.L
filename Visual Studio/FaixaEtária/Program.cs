string n;
int i;
Console.WriteLine("Digite o seu nome: ");
n = Console.ReadLine();
Console.WriteLine("Digite o sua idade: ");
i = int.Parse(Console.ReadLine());
if ((i > 0) && (i <= 5))
{
    Console.WriteLine("você é uma criança");
}
else if ((i >= 6) && (i <= 10))
{
    Console.WriteLine("você é um(a) garotinho(a)");
}
if ((i >= 11) && (i <= 15))
{
    Console.WriteLine("você é um(a) pré-adolescente");
}
else if  ((i >= 16) && (i <= 25))
{
    Console.WriteLine("você é um(a) jovem");
}
if ((i >= 26) && (i <= 45))
{
    Console.WriteLine("você é um(a) adulto(a)");
}
else if  ((i >= 46) &&  (i <= 60))
{
    Console.WriteLine("você é um(a) adulto(a) experiente");
}
if ((i >= 61) && (i <= 120))
{
    Console.WriteLine("você é um(a) idoso(a)");
}
else if (i > 120)
{
    Console.WriteLine("Você morreu");
}