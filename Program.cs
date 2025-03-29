double jurossimples;
double capital;
double taxa;
double tempo;
double montante;
Console.Write("Digite o capital inicial (0 a 255):");
capital = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a taxa");
taxa = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a tempo");
tempo = Convert.ToDouble(Console.ReadLine());

taxa = capital * (taxa * 100) * tempo;
jurossimples = capital*taxa*tempo;


montante = capital + jurossimples;
Console.WriteLine($"\nJuros :{jurossimples:C2}");
Console.WriteLine($"Montante :{montante:C2}");
