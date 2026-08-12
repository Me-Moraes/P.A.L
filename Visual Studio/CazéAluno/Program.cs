string n;
int m, rm;
Console.WriteLine("Digite seu nome");
n = Console.ReadLine();
Console.WriteLine("Digite seu número de registro de matrícula (RM)");
rm = int.Parse(Console.ReadLine());
Console.WriteLine(" 01 – Matemática \n 02 - Linguagem de Programação \n 03 – Português \n 04 - Inglês \n digite um dos números acima:");
m = int.Parse(Console.ReadLine());
switch (m)
{
    case 1:
        Console.WriteLine("O aluno(a) " + n + " com o número de matrícula referente a " + rm + " se inscreveu na matéria de Matemática");
        break;
    case 2:
        Console.WriteLine("O aluno(a) " + n + " com o número de matrícula referente a " + rm + " se inscreveu na matéria de Linguagem de Programação");
        break;
    case 3:
        Console.WriteLine("O aluno(a) " + n + " com o número de matrícula referente a " + rm + " se inscreveu na matéria de Português");
        break;
    case 4:
        Console.WriteLine("O aluno(a) " + n + " com o número de matrícula referente a " + rm + " se inscreveu na matéria de Inglês");
        break;
    default:
        Console.WriteLine("Opção inválida"); 
        break;
}