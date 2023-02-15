Console.WriteLine("Informe o comprimento do lado 1:"); //tamanho do lado 1.
double lado1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Informe o comprimento do lado 2:"); //tamanho do lado 2.
double lado2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Informe o comprimento do lado 3:"); //tamanho do lado 3.
double lado3 = Convert.ToDouble(Console.ReadLine());
//abaixo o código verifica se os valores inseridos será um triangulo ou não e informa qual será o triângulo.
if (lado1 + lado2 > lado3 && lado2 + lado3 > lado1 && lado1 + lado3 > lado2)
{
    if (lado1 == lado2 && lado2 == lado3)
    {
        Console.WriteLine("Triângulo Equilátero");
    }
    else if (lado1 == lado2 || lado2 == lado3 || lado1 == lado3)
    {
        Console.WriteLine("Triângulo Isósceles");
    }
}
else
{
    Console.WriteLine("As medidas informadas não formam um triângulo."); //Resposta de medidas que não formam um triângulo.
}