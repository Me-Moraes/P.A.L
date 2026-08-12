int n;
Console.WriteLine("Digite um número par entre 0 e 10");
n = int.Parse(Console.ReadLine());
switch (n)
{
	case 0:
	case 2:
	case 4:
	case 6:
	case 8:
	case 10:
		Console.WriteLine("Número par igual ou menor que Dez");
        break;
    default:
        Console.WriteLine("Número ímpar menor que Dez");
        break;
}
