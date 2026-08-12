double v, t, p, vt;
Console.WriteLine("Digite o valor: ");
v = double.Parse(Console.ReadLine());
Console.WriteLine("Digite a taxa: ");
t = double.Parse(Console.ReadLine());
Console.WriteLine("Digite a quantidade de parcelas: ");
p = double.Parse(Console.ReadLine());
vt = v + (v * (t / 100) * p);
Console.WriteLine("o valor total é: " + vt);