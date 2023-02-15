string opcao; //Variável.
do //Retorna valores até escolher a opção para sair.
{
    Console.WriteLine("Bem vindo ao Floripa Bank, selecione uma opção:");
    Console.WriteLine("1 - Deposito");
    Console.WriteLine("2 - Consultar Extrato");
    Console.WriteLine("3 - Sair");
    Console.Write("Opção: ");
    opcao = Console.ReadLine(); //Pergunta o que o cliente deseja realizar.
    if (opcao == "1") // Escolhendo a opção 1.
    {
        Console.WriteLine("Deposito"); //Entra na opção desejada.
    }
    else if (opcao == "2") //Escolhendo a opção 2.
    {
        Console.WriteLine("Consultar Extrato"); //Entra na opção desejada.
    }
    else if (opcao != "3") //Escolhendo a opção diferente entre 1 a 3.
    {
        Console.WriteLine("Opção inválida, selecione uma opção válida.");
    }
} while (opcao != "3"); //Escolhendo a opção 3 para sair.