double r, qtdpar, num;
qtdpar = 0;
for (int i = 1; i <= 15; i++)
{
    Console.WriteLine("Digite um número: ");
    num = double.Parse(Console.ReadLine());
    r = num %2;
    if (r == 0)
    {
        Console.WriteLine(num + " é par");
        qtdpar++;
    }

}
Console.WriteLine("Quantidade de números pares: " + qtdpar);
