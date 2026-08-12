double p, n1, n2;
Console.WriteLine("Digite o primeiro número: ");
n1 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo número: ");
n2 = double.Parse(Console.ReadLine());
p = Math.Pow(n1, n2);
Console.WriteLine("O resultado da potência é: " + p);