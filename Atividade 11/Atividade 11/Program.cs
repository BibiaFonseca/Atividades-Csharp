/*Faça uma aplicação de console que solicite dois números
ao usuário e tente somá-los. Se o usuário digitar algo que
não seja um número, exiba uma mensagem de erro
apropriada. Use try-catch para tratar possíveis exceções
de conversão. */

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