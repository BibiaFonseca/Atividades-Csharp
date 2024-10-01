/*Crie um programa que solicite ao usuário para inserir um
número positivo e, em seguida, exiba a tabuada desse
número de 1 a 10.*/


Console.WriteLine("Digite um número positivo");
int numero = int.Parse(Console.ReadLine());

Console.WriteLine($"A tabuada do {numero} é: ");
for (int i = 0; i <= 10; i++)
{
    Console.WriteLine($"{numero} x {i} =  {numero * i}");
}

Console.ReadKey();