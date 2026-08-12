double r = 0;
for (int i = 1; i <= 100; i++)
{
    r = i % 2;
    if (r == 0)
    {
        Console.WriteLine(i);
    }
}