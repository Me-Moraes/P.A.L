int cv;
double ml, m, c, d;
Console.WriteLine(" 1 - decímetros \n 2 - Centímetros \n 3 - Milimetros \n digite uma opção de converção acima:");
c = int.Parse(Console.ReadLine());
Console.WriteLine(" digite em metros a medida:");
m = double.Parse(Console.ReadLine());
switch (c)
{
    case 1:
        d = m * 10.0;
        Console.WriteLine(" A converção de " + m + " metros em decímetros foi " + d);
        break;
    case 2:
        c = m * 100.0;
        Console.WriteLine(" A converção de " + m + " metros em centímetros foi " + c);
        break;
    case 3:
        ml = m * 1000.0;
        Console.WriteLine(" A converção de " + m + " metros em milímetros foi " + ml);
        break;
    default:
        Console.WriteLine("Conversão inválida");
        break;
}
