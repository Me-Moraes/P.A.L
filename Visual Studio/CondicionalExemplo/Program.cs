int num;
Console.WriteLine("Digite um número");
num = int.Parse(Console.ReadLine());
if (num > 80)
{
    Console.WriteLine("O número digitado é maior que 80");


}
else if(num == 80)
{
    Console.WriteLine("O número digitado e igual a 80");
}
else
{
    Console.WriteLine("O número digitado é menor que 80");
}
