using EspacioCalculadora;

// Console.WriteLine("Ingrese el primer numero: ");
// double.TryParse(Console.ReadLine(), out double dato);

Calculadora miCalculadora = new Calculadora();
miCalculadora.Sumar(25);
miCalculadora.Sumar(10);
miCalculadora.Sumar(25);
Console.WriteLine($"El resultado de la suma: {miCalculadora.GetResultado()}");
miCalculadora.Dividir(2);

Console.WriteLine($"El resultado de la division: {miCalculadora.GetResultado()}");

