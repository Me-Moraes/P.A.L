double sa, sn;
string ce;
Console.WriteLine("Digite sua categoria");
ce = Console.ReadLine();
Console.WriteLine("Digite seu alário");
sa = int.Parse(Console.ReadLine());
switch (ce.ToLower())
{
    case "a":
        sn = sa+(sa * 10) / 100;
        Console.WriteLine("com o aumento de 10% o seu alário de " + sa + " passou para " + sn);
    break;
    case "b":
        sn = sa + (sa * 15) / 100;
        Console.WriteLine("com o aumento de 15% o seu alário de " + sa + " passou para " + sn);
    break;
    case "c":
        sn = sa + (sa * 25) / 100;
        Console.WriteLine("com o aumento de 25% o seu alário de " + sa + " passou para " + sn);
    break;
    default:
        Console.WriteLine("sua categoria não receberá aumento de alário, sendo seu alário ainda de " + sa);
    break; 
}
