int s, n;
s = 0;
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine("digite um numero para somar");
    n = int.Parse(Console.ReadLine());
    s = s + n;
}   

Console.WriteLine("resultado soma " + s);