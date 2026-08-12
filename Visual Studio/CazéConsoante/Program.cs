string l;
Console.WriteLine("Digite uma letra");
l = Console.ReadLine();
switch (l.ToLower())
{
    case "b":
    case "c":
    case "d":
    case "f":
    case "g":
    case "h":
    case "j":
    case "k":
    case "l":
    case "m":
    case "n":
    case "p":
    case "q":
    case "r":
    case "s":
    case "t":
    case "v":
    case "w":
    case "x":
    case "y":
    case "z":
        Console.WriteLine("a letra " + l + " é Consoante");
        break;
    default:
        Console.WriteLine("a letra " + l + " é Vogal");
        break;
}
