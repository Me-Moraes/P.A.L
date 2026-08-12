int la, lb, lc;
Console.WriteLine("Digite o lado A do triângulo: ");
la = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o lado B do triângulo: ");
lb = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o lado C do triângulo: ");
lc = int.Parse(Console.ReadLine());
if ((la == lb) && ( lb == lc) && (lc == la))
{
    Console.WriteLine("Seu triângulo é um triângulo equilátero possui todos os três lados iguais");
}
else if ((la == lb) || (la == lc) || (lb == lc))
{
    Console.WriteLine("Seu triângulo é um triângulo isósceles possui pelo menos dois lados de mesma medida");
}
if ((la != lb) && (la != lc) && (lb != lc))
{
    Console.WriteLine("Seu triângulo é um triângulo escaleno, as medidas dos três lados são diferentes");
}