string n1, n2;
double mda1, mda2;
Console.WriteLine("Digite o nome do primeiro aluno(a):");
n1 = Console.ReadLine();
Console.WriteLine("Digite o nome do segundo aluno(a):");
n2 = Console.ReadLine();
Console.WriteLine("Digite a nota do primeiro aluno(a):");
mda1 = double.Parse (Console.ReadLine());
Console.WriteLine("Digite a nota do segundo aluno(a):");
mda2 = double.Parse(Console.ReadLine());

//Aluno(a) 1

if  (mda1 >= 9.0)
{
    Console.WriteLine(n1 + " foi aprovado(a) com um A");
}
else if ((mda1 >= 7.5) && (mda1 < 9.0))
{
    Console.WriteLine(n1 + " foi aprovado(a) com um B");
}
if ((mda1 >= 6.0) && (mda1 < 7.5))
{
    Console.WriteLine(n1 + " foi aprovado(a) com um C");
}
else if ((mda1 >= 6.0) && (mda1 < 4.0))
{
    Console.WriteLine(n1 + " foi reprovado(a) com um D");
}
if ((mda1 >= 4.0) && (mda1 < 0))
{
    Console.WriteLine(n1 + " foi reprovado(a) com um E");
}

//Aluno(a) 2

if (mda2 >= 9.0)
{
    Console.WriteLine(n2 + " foi aprovado(a) com um A");
}
else if ((mda2 >= 7.5) && (mda2 < 9.0))
{
    Console.WriteLine(n2 + " foi aprovado(a) com um B");
}
if ((mda2 >= 6.0) && (mda2 < 7.5))
{
    Console.WriteLine(n2 + " foi aprovado(a) com um C");
}
else if ((mda2 >= 6.0) && (mda2 < 4.0))
{
    Console.WriteLine(n2 + " foi reprovado(a) com um D");
}
if ((mda2 >= 4.0) && (mda2 < 0))
{
    Console.WriteLine(n2 + " foi reprovado(a) com um E");
}