Console.Write("Insira o nome do aluno: ");//Nome do aluno
string nome;
nome = Console.ReadLine(); //Resposta.
Console.Write("Insira a primeira nota: "); //Valor da primeira nota.
decimal nota1;
nota1 = decimal.Parse(Console.ReadLine()); //Resposta.
Console.Write("Insira a segunda nota: "); //Valor da segunda nota.
decimal nota2;
nota2 = decimal.Parse(Console.ReadLine()); //Resposta.
Console.Write("Insira a terceira nota: "); //Valor da terceira nota.
decimal nota3;
nota3 = decimal.Parse(Console.ReadLine()); //Resposta.
decimal mediaNota;
mediaNota = ((nota1 + nota2 + nota3) / 3); //Calcula o valor das três notas e tira a média.
if (mediaNota >= 6) //Média maior ou igual a 6.
{
    Console.Write("Aluno aprovado com média: " + mediaNota); //Aprovado.
}
else if (mediaNota >= 5 && mediaNota < 6) //Média 5
{
    Console.Write("Aluno em recuperação com média: " + mediaNota); //Aluno em recuperação.
}
else
{
    Console.Write("Aluno reprovado com média: " + mediaNota); //Média maior que 6, aluno aprovado.
}
