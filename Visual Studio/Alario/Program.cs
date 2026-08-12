double vha, nht, sb, sl;
Console.WriteLine("Digite o valor da hora trabalhada:");
vha = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o número de horas trabalhadas no mês:");
nht = double.Parse(Console.ReadLine());
sb = nht * vha;
if (sb == 1000)
{
    sl = sb - (sb * 5) / 100;
    Console.WriteLine("o seu salário liquido com o desconto de 7% é de " + sl + ", sendo seu salário bruto igual a " + sb);
}
else if ((sb > 1000) && (sb <= 4000))
{
    sl = sb - (sb * 7) / 100;
    Console.WriteLine("o seu salário liquido com o desconto de 7% é de " + sl + ", sendo seu salário bruto igual a " + sb);
}
else if (sb > 4000)
{
    sl = sb - (sb * 10) / 100;
    Console.WriteLine("o seu salário liquido com o desconto de 10% é de " + sl + ", sendo seu salário bruto igual a " + sb);
}
else
{
    Console.WriteLine("Você não tem aumento de salário");
}
