int aa, an, tt, ai, i;
string n;
Console.WriteLine("Escreva o seu nome: ");
n = Console.ReadLine();
Console.WriteLine("Digite o ano atual: ");
aa = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o ano de nascimento: ");
an = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o ano de ingresso na clt: ");
ai = int.Parse(Console.ReadLine());
i = aa - an;
tt = aa - ai;
if (i >= 65)
{
    Console.WriteLine("a idade de " + n + " é igual a " + i + " anos, sendo assim ele(a) já pode se aposentar");
}
else if (tt >= 30)
{
    Console.WriteLine("o tempo de contribuição de " + n + " é igual a " + tt + " anos, sendo assim ele(a) já pode se aposentar");
}
if ((i >= 60) && (tt >= 25))
{
    Console.WriteLine("o tempo de contribuição de " + n + " é igual a " + tt + " anos junto com sua idade sendo igual a " + i + " anos, sendo assim ele(a) já pode se aposentar");
}
else
{
    Console.WriteLine("Erro, provávelmente você não tem a idade miníma ou tempo de contribuição suficiente para se aposentar");
}