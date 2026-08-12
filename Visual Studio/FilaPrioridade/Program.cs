int p;
Console.WriteLine("Se você é gestante, idoso ou cadeirante digite respectivamente 1, 2 ou 3 para receber acesso prioritário");
p = int.Parse(Console.ReadLine());
if ((p == 1) || (p == 2) || (p == 3))
{
    Console.WriteLine("você obteve acesso a fila prioritária");
}
else
{
    Console.WriteLine("Você não precisa de fila prioritária");
}