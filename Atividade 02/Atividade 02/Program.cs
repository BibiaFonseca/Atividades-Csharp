double n1, n2;
double soma = 0;
double sub = 0;
double multi = 0;
double div = 0;

Console.WriteLine("Informe o primeiro valor:");
n1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Informe o segundo valor:");
n2 = Convert.ToDouble(Console.ReadLine());

soma = n1 + n2;
Console.WriteLine($"A soma dos valores é: {soma}");

sub = n1 - n2;
Console.WriteLine($"A subtração dos valores é: {sub}");

multi = n1 * n2;
Console.WriteLine($"A multiplicação dos valores é: {multi}");

div = n1 / n2;
Console.WriteLine($"A divisão dos valores é: {div}");
Console.ReadKey();