string op;
double n1, n2, m, d, a, s;
Console.WriteLine("Digite o primeiro número");
n1 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo número");
n2 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite a operação deseja: \n + = soma \n - = subtração \n * = multiplicação \n / = divisão");
op = Console.ReadLine();
switch (op)
{
    case "+":
        a = n1 + n2;
        Console.WriteLine("a soma dos dois valores é " + a);
        break;
    case "-":
        s = n1 - n2;
        Console.WriteLine("a subtração dos dois valores é " + s);
        break;
    case "*":
        m = n1 * n2;
        Console.WriteLine("a multiplicação dos dois valores é " + m);
        break;
    case "/":
        d = n1 / n2;
        Console.WriteLine("a divisão dos dois valores é " + d);
        break;
    default:
        Console.WriteLine("Operação inválida");
        break;
}