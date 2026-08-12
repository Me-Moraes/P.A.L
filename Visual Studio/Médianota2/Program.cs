string n1, n2;
double n1a1, n2a1, n3a1, n4a1, n5a1, n1a2, n2a2, n3a2, n4a2, n5a2, nma1, nma2;
Console.WriteLine("Escreva o nome da primeira pessoa");
n1 = Console.ReadLine();
Console.WriteLine("Escreva o nome da segunda pessoa");
n2 = Console.ReadLine();
Console.WriteLine("Digite a primeira nota da primeira pessoa");
n1a1 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite a segunda nota da primeira pessoa");
n2a1 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite a terceira nota da primeira pessoa");
n3a1 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite a quarta nota da primeira pessoa");
n4a1 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite a quinta nota da primeira pessoa");
n5a1 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a primeira nota da segunda pessoa");
n1a2 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite a segunda nota da segunda pessoa");
n2a2 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite a terceira nota da segunda pessoa");
n3a2 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite a quarta nota da primeira pessoa");
n4a2 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite a quinta nota da primeira pessoa");
n5a2 = double.Parse(Console.ReadLine());

nma1 = (n1a1 + n2a1 + n3a1 + n4a1 + n5a1) / 5;
nma2 = (n1a2 + n2a2 + n3a2 + n4a2 + n5a2) / 5;
if (nma1 > nma2)
{
    Console.WriteLine(n1 + " tem uma média de " + nma1 + ", superior a de " + n2);
}
else
{
    Console.WriteLine(n2 + " tem uma média de " + nma2 + ", superior a de " + n1);
}
