Console.WriteLine("Qual o nome do aluno?");
string nomeAluno = Console.ReadLine();
Console.WriteLine("Quantas notas serão usadas para compor a média?");
int quantidadeNotas = int.Parse(Console.ReadLine());
double soma = 0;
for (int i = 1; i <= quantidadeNotas; i++)
{
    Console.WriteLine("Digite a nota " + i);
    double nota = double.Parse(Console.ReadLine());
    soma += nota;
}
double media = soma / quantidadeNotas;
string situacao;
if (media >= 6)
{
    situacao = "Aprovado";
}
else if (media >= 5)
{ }
{
    situacao = "Reprovado";
}
Console.WriteLine("Aluno: " + nomeAluno);
Console.WriteLine("Média: " + media + " - " + situacao);