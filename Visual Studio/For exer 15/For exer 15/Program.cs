double r, num;
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine("Digite um número: ");
    num = double.Parse(Console.ReadLine());
    r = num % 4;
    if (r == 0)
    {
    Console.WriteLine(num + " é múltiplo de 4");
    }

}
