int idade;
Console.WriteLine("Digite sua idade");
idade = int.Parse(Console.ReadLine());
switch (idade)
{
    case 0:
    case 1:
    case 2:
    case 3:
    case 4:
    case 5:
    case 6:
    case 7:
    case 8:
    case 9:
        Console.WriteLine("SUa idade é inferior a 10");
        break;
    case 10:
        Console.WriteLine("Você tem 10 anos, não pode entrar");
        break;
    case 11:
        Console.WriteLine("Você tem 11 anos, não pode entrar");
        break;
    case 12:
        Console.WriteLine("Você tem 12 anos, não pode entrar");
        break;
    case 13:
        Console.WriteLine("Você tem 13 anos, não pode entrar");
        break;
    case 14:
        Console.WriteLine("Você tem 14 anos, não pode entrar");
        break;
    case 15:
        Console.WriteLine("Você tem 15 anos, não pode entrar");
        break;
    default:
        Console.WriteLine("Você tem" + idade + " você pode entrar");
        break;
}