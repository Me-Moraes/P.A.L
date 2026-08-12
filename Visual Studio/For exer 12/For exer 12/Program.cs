double t, m;
Console.WriteLine("Digite uma tabuada:");
t = double.Parse(Console.ReadLine());
for (int i = 1; i <= 10; i++)
{
    m = t * i;
    Console.WriteLine("{0} x {1} = {2}", t, i, m);
}