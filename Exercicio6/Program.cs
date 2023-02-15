int tabuada, resultado;
Console.WriteLine("Qual numero deseja consultar? ");
tabuada = int.Parse(Console.ReadLine());
int num = 0;
do
{
    resultado = tabuada * num;
    Console.WriteLine(resultado);
    num = num + 1;
} while (num <= 10);