string letra;
Console.WriteLine("Digite uma letra: ");
letra = Console.ReadLine();
switch (letra.ToLower())
{
    case "a":
        Console.WriteLine("Você escolheu refrigerante");
        break;
    case "b":
        Console.WriteLine("Você escolheu pipoca");
        break;
    case "c":
        Console.WriteLine("Você escolheu Chocolate");
        break;
    default:
        Console.WriteLine("Você deve escolher as opções a, b, c");
        break;
}