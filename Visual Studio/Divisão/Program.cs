double n1, n2, r;
Console.WriteLine("Digite o primeiro número: ");
n1 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo número: ");
n2 = double.Parse(Console.ReadLine());
if (n1 > n2)
{
    r = n1 / n2;
    Console.WriteLine("O maior número é " + n1 + ", sendo assim " + n1 + " dividido por " + n2 + " tem o resultado igual a " + r);  
}
else
{ 
    r = n2 / n1;
    Console.WriteLine("O maior número é " + n2 + ", sendo assim " + n2 + " dividido por " + n1 + " tem o resultado igual a " + r);
}