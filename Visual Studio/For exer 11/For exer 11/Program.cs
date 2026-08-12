double r, q;
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Digite um número:");
    q = double.Parse(Console.ReadLine());
    r = Math.Pow(q, 2);
    Console.WriteLine("o quadrado de " + q + " é " + r);
}