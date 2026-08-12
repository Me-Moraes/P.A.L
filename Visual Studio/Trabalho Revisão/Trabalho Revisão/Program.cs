int ano, hex;
double sb, sm, sl, sbru, inss, calcins, calcper, calchex, calcadn;
string n, m, per, ins, adn;
Console.WriteLine("Digite o nome do funcionario");
n = Console.ReadLine();
Console.WriteLine("Digite o salário base");
sb = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o salário minimo");
sm = double.Parse(Console.ReadLine());
Console.WriteLine("Escreva o mês do pagamento");
m = Console.ReadLine();
Console.WriteLine("Digite o ano referente ao pagamento");
ano = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a quantidade de horas extras");
hex = int.Parse(Console.ReadLine());
Console.WriteLine("Digite sim ou não para adicional noturno");
adn = Console.ReadLine();
Console.WriteLine("Digite sim ou não para periculosidade");
per = Console.ReadLine();
Console.WriteLine("Digite \n baixo \n médio \n alto \n não tem \n para insalubridade");
ins = Console.ReadLine();
Console.WriteLine("Digite o valor do inss");
inss = double.Parse(Console.ReadLine());
// Calc Insalubridade
switch (ins.ToLower())
{
    case "baixo":
        calcins = (sm * 10) / 100;
        break;
    case "médio":
        calcins = (sm * 20) / 100;
        break;
    case "alto":
        calcins = (sm * 30) / 100;
        break;
    default:
        calcins = 0;
        break;
}
// Calc periculosidade
if (per == "sim".ToLower())
{
    calcper = (sb * 30) / 100;
}
else
{
    calcper = 0;
}
// Calc Horas extras
calchex = (calcins + sb + calcper) / 220 * 1.5 * hex;
// Calc Adicional noturno
switch (adn.ToLower())
{
    case "sim":
        calcadn = (sb * 20) / 100;
        break;
    default:
        calcadn = 0;
        break;
}
// Calc Salário bruto
sbru = sb + calchex + calcins + calcper + calcadn;
// Calc INSS
if (sbru <= 1174.86)
{
    inss = (sbru * 8) / 100;
}
else if ((sbru >= 1174.87) && (sbru <= 1958.10))
{
    inss = (sbru * 9) / 100;
}
else if ((sbru >= 1958.10) && (sbru <= 3916.20))
{
    inss = (sbru * 11) / 100;
}
else if (sbru > 3916.20)
{
    inss = (3916.20 * 11) / 100;
}
// Calc Salário liquído
sl = sbru - inss;
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("===========$$$$$============ FOLHA DE PAGAMENTO======$$$$$==================\r\n\r\n===DADOS INFORMADOS====\r\n\r\nNome do Funcionário:" + n + "\r\n\r\nMês de Referência:" + m + " / " + ano + "\r\n\r\nSalário Base:" + sb + " \r\n\r\nSalário Mínimo:" + sm + "\r\n\r\nHoras Extras:" + hex + " horas \r\n\r\nPericulosidade:" + per + "\r\n\r\nInsalubridade: " + ins + "\r\n\r\nAdicional Noturno: " + adn + "\r\n\r\n\r\n===CÁLCULOS DO FUNCIONÁRIO===\r\n\r\nValor da Insalubridade: " + calcins + "\r\n\r\nValor da Periculosidade: " + calcper + "\r\n\r\nValor Hora Extra: " + calchex + "\r\n\r\nAdicional Noturno: " + calcadn + "\r\n\r\nSalário Bruto: " + sbru + "\r\n\r\nDesconto INSS: " + inss + "\r\n\r\nSalário Líquido: " + sl + "\r\n\r\n==========================FIM DA FOLHA DE PAGAMENTO=========================");