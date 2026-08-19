double r, mult = 0, qtdpos;
qtdpos = 0;
for (int i = 1; i <= 50; i++)
{
    r = i % 3;
    if (r == 0)
    {
        mult += i;
        Console.WriteLine(" a soma dos múltiplos de 3: " + mult);
        qtdpos++;
    }

}
