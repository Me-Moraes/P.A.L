int idp;
Console.WriteLine("Digite o nível de poluíção");
idp = int.Parse(Console.ReadLine());
switch (idp)
{
    case 0:
    case 1:
    case 2:
        Console.WriteLine("o nível de poluíção é Considerado Aceitável");
        break;
    case 3:
    case 4:
    case 5:
        Console.WriteLine("o nível de poluíção é acima da média,  Suspender Atividades do Grupo 1");
        break;
    case 6:
    case 7:
        Console.WriteLine("o nível de poluíção é alto, Suspender Atividades dos Grupos 1 e 2");
        break;
    default:
        Console.WriteLine("o nível de poluíção é muito alto,  Suspender atividade de todos os grupos");
        break;
}