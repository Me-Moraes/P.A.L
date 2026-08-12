using System.ComponentModel.Design;

string l;
Console.WriteLine("Digite uma vogal: ");
l = Console.ReadLine();
if ((l == "a") || (l == "e") || (l == "i") || (l == "o") || (l == "u"))
{
    Console.WriteLine("Essa letra é uma vogal");
}
else
{
    Console.WriteLine("Essa letra é uma consoante");
}