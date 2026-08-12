int n;
Console.WriteLine("Escolha uma das profissões abaixo \n 1- Programador \n 2- Professor \n3- Administrador");
n = int.Parse(Console.ReadLine());
switch (n)
{
    case 1:
        Console.WriteLine("Você escolheu Programador");
        break;
    case 2:
        Console.WriteLine("Você escolheu Professor");
        break;
    case 3:
        Console.WriteLine("Você escolheu administrador");
        break;
    default:
        Console.WriteLine("Erro, número errado");
        break;
}
