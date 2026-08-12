double a, r, alt;
Console.WriteLine("Digite o raio: ");
r = double.Parse(Console.ReadLine());
Console.WriteLine("Digite a altura: ");
alt = double.Parse(Console.ReadLine());
a = 3.14 * Math.Pow(r, 2) * alt;
Console.WriteLine("O volume da circunferência é: " + a);