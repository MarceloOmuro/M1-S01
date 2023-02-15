Console.WriteLine("Nome do Funcionario: "); //Solicita o nome do funcionário.
string nome;
nome = Console.ReadLine();// //Resposta.
Console.WriteLine("Qual é o salário bruto?"); //Solicita o salário bruto.
decimal salario; //valor do salário.
decimal salarioLiquido; //valor do salário com o desconto do imposto.
decimal imposto; //Valor do imposto
salario = decimal.Parse(Console.ReadLine());
if (salario <= 900) //Caso o salário seja menor ou igual a 900.
{
    Console.WriteLine("Imposto = Isento"); //Isento de imposto.
    Console.WriteLine("Salário Líquido: " + salario); //Valor do salário
}
else if
(salario > 900 && salario <= 1500) //Caso o salário seja entre 901 a 1500.
{
    imposto = (salario * 5) / 100; //Imposto de 5%
    Console.WriteLine("Imposto = " + imposto);
    salarioLiquido = salario - imposto; //Salário líquido.
    Console.WriteLine("Salário Líquido: " + salarioLiquido);
}
else if (salario > 1500 && salario <= 2500) //Caso o salário seja entre 1501 à 2500
{
    imposto = (salario * 10) / 100; //Imposto de 10%
    Console.WriteLine("Imposto = " + imposto);
    salarioLiquido = salario - imposto; //Salário líquido.
    Console.WriteLine("Salário Líquido: " + salarioLiquido);
}
else if (salario > 2500)
{
    imposto = (salario * 20) / 100; //Imposto de 20%
    Console.WriteLine("Imposto = " + imposto);
    salarioLiquido = salario - imposto; //Salário líquido.
    Console.WriteLine("Salário Líquido: " + salarioLiquido);
}