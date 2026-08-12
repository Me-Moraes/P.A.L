double n1, n2, m, d, p, op;
Console.WriteLine(" 1 - Média entre dois números \n 2 - Diferença entre dois números \n 3 - Produto entre dois números.  \n digite uma opção de opereção acima:");
op = int.Parse(Console.ReadLine());
Console.WriteLine(" digite o primeiro número:");
n1 = double.Parse(Console.ReadLine());
Console.WriteLine(" digite o segundo número:");
n2 = double.Parse(Console.ReadLine());
switch (op)
{
    case 1:
        m = (n1+n2)/2;
        Console.WriteLine("a média entre" + n1 + " e " + n2 + " é " + m);
        break;
    case 2:
        d = n1 - n2;
        Console.WriteLine("a diferença entre" + n1 + " e " + n2 + " é " + d);
        break;
    case 3:
        p = n1 * n2;
        Console.WriteLine("O produto de " + n1 + " e " + n2 + " é " + p);
        break;
    default:
        Console.WriteLine("Operação inválida");
        break;
}
