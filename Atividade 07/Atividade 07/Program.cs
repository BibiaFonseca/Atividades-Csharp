double nota1;
double nota2;
double nota3;
double soma;
double div;

Console.WriteLine("Insira a primeira nota:");
nota1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Insira a segunda nota:");
nota2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Insira a terceira nota:");
nota3 = Convert.ToDouble(Console.ReadLine());

soma = nota1 + nota2 + nota3;
div = soma / 3;

Console.WriteLine($"A média das notas é: {div}");