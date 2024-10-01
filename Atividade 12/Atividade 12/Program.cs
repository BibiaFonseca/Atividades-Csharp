/*Crie um programa que classifique a nota de um aluno com
base nas seguintes regras:

Nota de 90 a 100: A
Nota de 80 a 89: B
Nota de 70 a 79: C
Nota de 60 a 69: D
Nota abaixo de 60: F*/

Console.WriteLine("Digite a sua nota: ");
double nota = double.Parse(Console.ReadLine());

if (nota < 60)
{
    Console.WriteLine($"Sua nota foi {nota} e sua classificação foi F D:");
}
else if (nota >= 60 && nota <= 69)
{
    Console.WriteLine($"Sua nota foi {nota} e sua classificação foi D :(");
}
else if (nota >= 70 && nota <= 79)
{
    Console.WriteLine($"Sua nota foi {nota} e sua classificação foi C :|");
}
else if (nota >= 80 && nota <= 89)
{
    Console.WriteLine($"Sua nota foi {nota} e sua classificação foi B :)");
}
else if(nota > 91 && nota <= 100)
{
    Console.WriteLine($"Sua nota foi {nota} e sua classificação foi A :D");
}
else
{
    Console.WriteLine("Digite uma nota válida");
}
Console.ReadKey();
