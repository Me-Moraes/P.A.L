string l;
Console.WriteLine("Digite uma letra");
l = Console.ReadLine();
switch (l.ToLower())
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":

        Console.WriteLine("a letra " + l + " é Consoante");
        break;
    default:
        Console.WriteLine("a letra " + l + " é ");
        break;
}