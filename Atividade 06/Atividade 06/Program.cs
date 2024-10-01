double salario;
double percentual;
double div;
double multi;
double resul;

Console.WriteLine("Digite seu salário:");
salario = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite um percentual de aumento:");
percentual = Convert.ToDouble(Console.ReadLine());

div = percentual / 100;
multi = div * salario;
resul = salario + multi;
Console.WriteLine($"O seu salário com o aumento percentual inserido é de: {resul}");





