double velo, dist, temp;
Console.WriteLine("Digite a distância: ");
dist = double.Parse(Console.ReadLine());
Console.WriteLine("Digite a tempo: ");
temp = double.Parse(Console.ReadLine());
velo = (dist * 1000)/(temp * 60);
Console.WriteLine("A função horária é: " +  velo);