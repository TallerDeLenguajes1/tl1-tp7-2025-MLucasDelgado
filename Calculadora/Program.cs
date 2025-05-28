using EspacioCalculadora;

// Console.WriteLine("Ingrese el primer numero: ");
// double.TryParse(Console.ReadLine(), out double dato);

bool seguir = true;

Console.Write("Ingrese un número inicial: ");
double.TryParse(Console.ReadLine(), out double num);
Calculadora miCalculadora = new Calculadora(num);

while (seguir)
{
    string operacion = ElegirOperacion();


    switch (operacion)
    {
        case "1":
            miCalculadora.Sumar(pedirNumero());
            break;
        case "2":
            miCalculadora.Restar(pedirNumero());
            break;
        case "3":
            miCalculadora.Multiplicar(pedirNumero());
            break;
        case "4":
            miCalculadora.Dividir(pedirNumero());
            break;
        case "5":
            miCalculadora.Limpiar();
            Console.WriteLine("✅ Calculadora reiniciada. Se le pedira un nuevo valor inicial");
            double nuevoInicio = pedirNumero();
            miCalculadora = new Calculadora(nuevoInicio);
            break;
        case "6":
            Console.WriteLine("👋 Saliendo de la calculadora.");
            seguir = false;
            break;
        default:
            Console.WriteLine("Opción inválida");
            break;
    }

    Console.WriteLine($"\nResultado actual: {miCalculadora.GetResultado()}");
}

string ElegirOperacion()
{
    Console.WriteLine("\n----------- OPERACIONES -----------");
    Console.WriteLine("1 - Sumar");
    Console.WriteLine("2 - Restar");
    Console.WriteLine("3 - Multiplicar");
    Console.WriteLine("4 - Dividir");
    Console.WriteLine("5 - Limpiar calculadora");
    Console.WriteLine("6 - Salir");

    Console.WriteLine("Elegir una opción: ");

    string opcion = Console.ReadLine();
    return opcion;
}

double pedirNumero()
{
    Console.Write("Ingrese un valor: ");
    if (double.TryParse(Console.ReadLine(), out double numero))
    {
        return numero;
    }
    else
    {
        Console.WriteLine("Entrada inválida. Se usará 0.");
        return 0;
    }
}

