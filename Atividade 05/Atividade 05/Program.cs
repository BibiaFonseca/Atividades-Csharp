double deci;
int inteiro;

Console.WriteLine("Insira um número decimal");
deci = Convert.ToDouble(Console.ReadLine());

inteiro = Convert.ToInt32(deci);

Console.WriteLine($"O número decimal convertido para inteiro é: {inteiro}");