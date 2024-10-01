/*Crie um programa de console que solicite ao usuário que
informe um número de 1 a 12 (representando os meses do
ano) e, utilizando a estrutura switch, exiba a estação
correspondente ao mês informado.

Ordem das estações:

Meses de dezembro, janeiro e fevereiro: Verão
Meses de março, abril e maio: Outono
Meses de junho, julho: e agosto: Inverno
Meses de setembro, outubro e novembro: Primavera*/
int mes;

Console.WriteLine("Insira um número de 1 a 12 para descobrir a estação correspondente.");
mes = Convert.ToInt32(Console.ReadLine());

switch (mes)
{
    case 12:
    case 1:
    case 2:

        Console.WriteLine("A estação desse mês é o verão.");
        break;

    case 3:
    case 4:
    case 5:
        Console.WriteLine("A estação desse mês é o outono.");
        break;

    case 6:
    case 7:
    case 8:
        Console.WriteLine("A estação desse mês é o inverno.");
        break;

    case 9:
    case 10:
    case 11:
        Console.WriteLine("A estação desse mês é a primavera.");
        break;

}