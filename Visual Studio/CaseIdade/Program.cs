int cat;
Console.WriteLine("Digite sua idade");
cat = int.Parse(Console.ReadLine());
switch (cat)
{
    case 5:
    case 6:
    case 7:
        Console.WriteLine("sua categoria é infantil A");
        break;
    case 8:
    case 9:
    case 10:
    case 11:
        Console.WriteLine("sua categoria é infantil B");
        break;
    case 12:
    case 13:
        Console.WriteLine("sua categoria é juvenil A");
        break;
    case 14:
    case 15:
    case 16:
    case 17:
        Console.WriteLine("sua categoria é juvenil B");
        break;
    default:
        Console.WriteLine("sua categoria é adulto");
        break;
}
