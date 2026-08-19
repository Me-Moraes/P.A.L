double r, qtdpos;
qtdpos = 0;
for (int i = 1; i <=300 ; i++)
{
    r = i % 3;
    if (r == 0)
    {
        Console.WriteLine(i + " é múltiplo de 3");
        qtdpos++;
    }

}
Console.WriteLine("A quantidade de numéros multiplos de 3 é " + qtdpos);