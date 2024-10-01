double pi = 3.14;
double raio;
double area;
double resul;

Console.WriteLine("Digite um raio para calcular a área do círculo.");
raio = Convert.ToDouble(Console.ReadLine());

area = raio * raio;
resul =  pi * area;

Console.WriteLine($"A área do seu círculo é: {resul} ");
