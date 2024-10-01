//TC/5 = (TF – 32)/9

double c;
double f;

Console.WriteLine("Insira uma temperatura em celcius:");
c = Convert.ToDouble(Console.ReadLine());

f = (c * 9 / 5) + 32;
Console.WriteLine($"A temperatura em fahrenheit é de: {f}");