/*Crie um programa em C# que solicite ao usuário um número positivo e, em seguida, exiba os valores impares até o
números que o usuário inseriu. Crie uma validação para que o usuário possa somente digitar números inteiros*/

int numero;

Console.WriteLine("Digite um número inteiro positivo:");
while (!int.TryParse(Console.ReadLine(), out numero) || numero <= 0)
{
    Console.WriteLine("Número inválido. Digite um número inteiro positivo:");
}

Console.WriteLine($"Os números ímpares de 0 até {numero} são:");

for (int i = 1; i <= numero; i += 2)
{
    Console.WriteLine(i);
}

Console.ReadKey();
