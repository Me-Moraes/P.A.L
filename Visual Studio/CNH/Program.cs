int aa, an, i;
string n;
Console.WriteLine("Escreva o seu nome: ");
n = Console.ReadLine();
Console.WriteLine("Digite o ano atual: ");
aa = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o ano de nascimento: ");
an = int.Parse(Console.ReadLine());
i = aa - an;
if (i >= 18)
{
    Console.WriteLine("a idade de " + n + " é igual a " + i + " anos, sendo assim ele(a) já pode tirar CNH");
}
else 
{
    Console.WriteLine("a idade de " + n + " é igual a " + i + " anos, sendo assim ele(a) ainda não pode tirar CNH");
}
