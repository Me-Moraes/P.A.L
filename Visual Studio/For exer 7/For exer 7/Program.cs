int id, qtd=0;
for (int i = 1; i <=5; i++)
{
    Console.WriteLine("Digite a idade");
    id = int.Parse(Console.ReadLine()); 
    if ((id >= 18) && (id <= 109)) 
    {
        qtd++;
        Console.WriteLine("essa pessoa é maior de idade");
    }
    else if (id > 109)
    {
        Console.WriteLine("essa pessoa está morta");
    }
    else
    {
        Console.WriteLine("Essa pessoa é menor de idade");
    }
}