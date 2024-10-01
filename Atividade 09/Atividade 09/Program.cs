string[] vetDiaSemana = new string[]
{
    "Segunda-Feira", 
    "Terça-Feira",  
    "Quarta-Feira",
    "Quinta-Feira",
    "Sexta-Feira",
    "Sábado",
    "Domingo"
};

string[] tarefas = new string[7];


Console.WriteLine($"Insira uma tarefa para cada dia da semana:");

for ( int i = 0; i < 7; i++ )
{
    Console.Write($"Tarefa para {vetDiaSemana[i]}: ");
    tarefas[i] = Console.ReadLine();
}

for (int i = 0; i < vetDiaSemana.Length; i++)
{
    Console.WriteLine($"Sua tarefa para {vetDiaSemana[i]} é: {tarefas[i]}");
}

Console.Write("Aperte uma tecla para encerrar o programa.");
Console.ReadKey();