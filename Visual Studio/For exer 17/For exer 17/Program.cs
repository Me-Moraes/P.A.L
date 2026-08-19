double altura, qtd = 0;
string sexo;
for (int i = 1; i <= 4; i++)
{
    Console.WriteLine("Digite a altura da pessoa: ");
    altura = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite o sexo da pessoa (M/F): ");
    sexo = Console.ReadLine();
    if (sexo == "F" || sexo == "f")
    {
        Console.WriteLine("A altura da mulher é: " + altura);
    }
    else if (sexo == "M" || sexo == "m")
    {
        qtd++;
        Console.WriteLine("A quantidade de homens é: " + qtd);
    }
}
