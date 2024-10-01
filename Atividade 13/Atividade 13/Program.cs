/*Crie um programa que permita ao usuário adivinhar um
número secreto. O número secreto será 7. O usuário deve
continuar tentando até adivinhar corretamente. Use um
loop do-while.*/

int numero;

do
{
    Console.WriteLine("Tente adivinhar o número secreto... Digite um número: ");
    numero = int.Parse(Console.ReadLine());

    if (numero != 7)
    {
        Console.WriteLine("Infelizmente esse não é o número secreto, tente novamente.");
    }
} while (numero != 7);

Console.WriteLine("Parabéns, você acertou o número secreto!");
Console.ReadKey();