/*Crie um programa em C# que solicite ao usuário um número positivo e, em seguida, calcule e exiba o **fatorial** desse
número. O fatorial de um número inteiro positivo **n** é a multiplicação de todos os números inteiros de 1 até **n**.

A fórmula do fatorial é representada como:

n! = n \(n - 1) \(n - 2)

Por exemplo:
5! = 5 4 3 2 1 = 120

Obs: Você deve verificar se o usuário inseriu um valor inteiro e só depois calcular o fatorial.*/



Console.WriteLine("Digite um número positivo");
if (int.TryParse(Console.ReadLine(), out int numero) && numero >= 0)
{
    double fatorial = 1;
    for (int i = 1; i <= numero; i++)
    {
        fatorial *= i;
    }
    Console.WriteLine($"O fatorial de {numero} é: {fatorial} ");
}
else
{
    Console.WriteLine("Número inválido, por favor digite um número válido.");
}

Console.ReadKey();