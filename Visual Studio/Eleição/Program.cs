int v;
Console.WriteLine("Digite um número para votar: \n 0 - voto em branco \n 1 - Aidento \n 2 - João Ernesto \n 3 - Padre Kelson");
v = int.Parse (Console.ReadLine());
switch (v)
{
    case 0:
        Console.WriteLine("Você votou em branco");
        break;
    case 1:
        Console.WriteLine("Você votou em Ai dento");
        break;
    case 2:
        Console.WriteLine("Você votou em Polvo");
        break;
    case 3:
        Console.WriteLine("Você votou em Padre Kelson");
        break;
    default:
        Console.WriteLine("Voto registrado como nulo");
        break;
}