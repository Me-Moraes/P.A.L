int qtdpos, qtdneg, num;
qtdpos = 0;
qtdneg = 0;
for (int i = 0; i <= 10; i++)
{
    Console.WriteLine("Digite um número:");
    num = int.Parse(Console.ReadLine());    
    if (num > 0)
    {
        qtdpos++;
    }
    else if (num < 0)
    {
        qtdneg++;
    }
}
Console.WriteLine("Quantidade de números positivos: " + qtdpos);
Console.WriteLine("Quantidade de números negativos: " + qtdneg);