Console.WriteLine("Qual é a base do triangulo? "); //Insira o valor da base do triângulo.
decimal baseTriangulo;
baseTriangulo = decimal.Parse(Console.ReadLine());  //Resposta.
Console.Write("Qual a altura do triângulo? "); //Insira a altura do triângulo.
decimal alturaTriangulo;
alturaTriangulo = decimal.Parse(Console.ReadLine()); //Resposta.
decimal areaDoTriangulo;
areaDoTriangulo = (baseTriangulo * alturaTriangulo) / 2; //Realiza o cálculo do triângulo.
Console.Write("A área do triângulo é igual: " + areaDoTriangulo); //Área do triângulo.