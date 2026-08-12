string c;
double valor, numlitros;
Console.WriteLine("Digite a quantidade de combustivel abastecido");
numlitros = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o tipo de combustivel abastecido, A = Alcool, G = Gasolina");
c = Console.ReadLine();
switch (c)
{
    case "A":
        valor = 5.89 * numlitros;
        Console.WriteLine("O valor pago no abastecimento foi" + valor);
        break;
    case "G":
        valor = 7.39 * numlitros;
        Console.WriteLine("O valor pago no abastecimento foi" + valor);
        break;
    default:
        Console.WriteLine("Letra incorreta");
        break;
}