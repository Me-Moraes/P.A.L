int ds;
Console.WriteLine("Digite o número do dia da semana: ");
ds = int.Parse(Console.ReadLine());
switch (ds)
{
    case 1:
        Console.WriteLine("o dia da semana é domingo");
        break;
    case 2:
        Console.WriteLine("o dia da semana é segunda-feira");
        break;
    case 3:
        Console.WriteLine("o dia da semana é terça-feira");
        break;
    case 4:
        Console.WriteLine("o dia da semana é quarta-feira");
        break;
    case 5:
        Console.WriteLine("o dia da semana é quinta-feira");
        break;
    case 6:
        Console.WriteLine("o dia da semana é sexta-feira");
        break;
    case 7:
        Console.WriteLine("o dia da semana é sábado");
        break;
    default:
        Console.WriteLine("Digite dia da semana incorreto");
        break;
}