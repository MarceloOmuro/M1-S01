// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Olá, tudo bem? Qual o seu nome?"); //Pergunta o nome.
string nome = Console.ReadLine(); //Resposta.

Console.WriteLine("Bem vindo, " + nome + ". E qual o seu sobrenome?"); //Pergunta o sobrenome.
string sobrenome = Console.ReadLine(); //Resposta.

Console.WriteLine("Quantos anos você tem,"); //Pergunta a idade.
string idade = Console.ReadLine(); //Resposta.

Console.WriteLine("E qual é a sua cor favorita,"); //Pergunta a cor favorita.
string corFavorita = Console.ReadLine(); //Resposta.

Console.WriteLine("RESPOSTAS DO USUÁRIO"); //Retorna todas as respostas.

Console.WriteLine("Você se chama " + nome + " " + sobrenome);
Console.WriteLine("Você tem " + idade + " anos");
Console.WriteLine("A sua cor preferida é" + " " + corFavorita);

