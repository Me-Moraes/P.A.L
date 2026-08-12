double a, ab, v;
Console.WriteLine("digite o lado do cubo:");
a = double.Parse(Console.ReadLine());
ab = Math.Pow(a, 2);
v = Math.Pow(a, 3);
Console.WriteLine("a área da base do cubo é " + ab + " e o volume do cubo é " + v);