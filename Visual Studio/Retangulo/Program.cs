double la, lb, a, p;
Console.WriteLine("Digite o lado A: ");
la = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o lado B: ");
lb = double.Parse(Console.ReadLine());
a = la * lb;
p = (2 * la) + (2 * lb);
Console.WriteLine("A área é " + a + ", o perímetro " + p);