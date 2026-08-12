double num, div;
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine("Digite um numero");
    num = double.Parse(Console.ReadLine());
    div = num / 2;
    Console.WriteLine("A metade é " + div);
}