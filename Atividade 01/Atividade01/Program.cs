string nome;
string sobrenome;
string areaprogramacao;


Console.WriteLine("Informe o seu nome:");
nome = Console.ReadLine();

Console.WriteLine("Informe o seu sobrenome:");
sobrenome = Console.ReadLine();

Console.WriteLine("Qual a área da programação que você mais se interessa?");
areaprogramacao = Console.ReadLine();

Console.WriteLine($"\nSeu nome completo é: {nome} {sobrenome} e a área da programação que você mais se interessa é: {areaprogramacao}");

