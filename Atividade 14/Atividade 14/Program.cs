/*Crie um programa que exiba um menu de opções para o
usuário. O usuário deve escolher uma opção e o programa
deve continuar exibindo o menu até que o usuário escolha
a opção de sair.
Opções do Menu:
1.Exibir uma mensagem
2.Fazer uma soma
3.Sair*/

using System.Diagnostics.Tracing;

int menu;

do
{
    Console.WriteLine("Escolha uma opção do nosso menu:\n 1.Exibir uma mensagem \n 2.Fazer uma soma \n 3.Sair ");
    menu = int.Parse(Console.ReadLine());

    if (menu == 1)
    {
        Console.WriteLine("Sua mensagem: Vá para Austrália em 63/10/2032 as 23:99. ");
    }
    if (menu == 2)
    {
        try
        {
            Console.WriteLine("Digite um número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro número: ");
            int num2 = int.Parse(Console.ReadLine());

            int resultado = num1 + num2;
            Console.WriteLine($"O resultado da soma desses números é: {resultado}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Erro: Por favor digite valores válidos.");
        }
    }

    if (menu == 3)
        {
        Console.WriteLine("Aperte qualquer tecla para sair.");
        Console.ReadKey();
    }

    if (menu > 3)
    {
        Console.WriteLine("Digite um número válido.");
    }
} while (menu == 1 || menu == 2 || menu > 3 );

