int m;
Console.WriteLine("Digite o número o mês do seu aniversário: ");
m = int.Parse (Console.ReadLine());
switch (m)
{
    case 1:
        Console.WriteLine("o mês do seu aniversário é janeiro");
        break;
    case 2:
        Console.WriteLine("o mês do seu aniversário é fevereiro");
        break;
    case 3:
        Console.WriteLine("o mês do seu aniversário é março");
        break;
    case 4:
        Console.WriteLine("o mês do seu aniversário é abril");
        break;
    case 5:
        Console.WriteLine("o mês do seu aniversário é maio");
        break;
    case 6:
        Console.WriteLine("o mês do seu aniversário é junho");
        break;
    case 7:
        Console.WriteLine("o mês do seu aniversário é julho");
        break;
    case 8:
        Console.WriteLine("o mês do seu aniversário é agosto");
        break;
    case 9:
        Console.WriteLine("o mês do seu aniversário é setembro");
        break;
    case 10:
        Console.WriteLine("o mês do seu aniversário é outubro");
        break;
    case 11:
        Console.WriteLine("o mês do seu aniversário é novembro");
        break;
    case 12:
        Console.WriteLine("o mês do seu aniversário é dezembro");
        break;
    default:
        Console.WriteLine("Digite o número do mês correto");
        break;
}