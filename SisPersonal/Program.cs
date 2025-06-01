using Personal;

Empleado[] empleados = new Empleado[3];

for (int i = 0; i < empleados.Length; i++)
{
    // PUNTO 2C
    Console.WriteLine($"\n--- Ingrese los datos para el empleado {i + 1} ---");

    Console.WriteLine("Ingrese el nombre: ");
    string nombreEmpleado = Console.ReadLine();

    Console.WriteLine("Ingrese el apellido: ");
    string apellidoEmpleado = Console.ReadLine();

    Console.WriteLine("Ingrese la fecha de nacimiento (formato AAAA-MM-DD): ");
    DateTime fechaNacimiento = DateTime.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese si el empleado esta casado o soltero (c/s): ");
    char estadoCivil = Convert.ToChar(Console.ReadLine());

    Console.WriteLine("Ingrese la fecha de ingreso a la empresa (formato AAAA-MM-DD): ");
    DateTime fechaIngreso = DateTime.Parse(Console.ReadLine());

    Console.Write("Ingrese el sueldo básico: ");
    double sueldo = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("\n--------RUBROS--------");
    Console.WriteLine("0 - Auxiliar Administrativo");
    Console.WriteLine("1 - Ingeniero");
    Console.WriteLine("2 - Especialista");
    Console.WriteLine("3 - Investigador");
    Console.WriteLine("Seleccione el cargo: ");
    int cargoInt = Convert.ToInt32(Console.ReadLine());
    Cargos cargo = (Cargos)cargoInt;

    empleados[i] = new Empleado
    {
        Nombre = nombreEmpleado,
        Apellido = apellidoEmpleado,
        FechaNacimiento = fechaNacimiento,
        EstadoCivil = estadoCivil,
        FechaIngreso = fechaIngreso,
        SalarioBasico = sueldo,
        Cargo = cargo
    };
}

// PUNTO 2A, 2D y 2E mostrados
double sueldoTotal = 0;
int jubilado = 100;

for (int i = 0; i < empleados.Length; i++)
{

    sueldoTotal += empleados[i].ObtenerSalario();

    int añosFaltantes = empleados[i].AñosParaJubilacion();

    if (añosFaltantes < jubilado)
    {
        jubilado = añosFaltantes;
    }
}

for (int i = 0; i < empleados.Length; i++)
{
    if (empleados[i].AñosParaJubilacion() == jubilado)
    {
        Console.WriteLine($"El empleado mas cercano a jubilarse es el N°{i + 1}");
        Console.WriteLine($"Nombre: {empleados[i].Nombre} {empleados[i].Apellido}");
        Console.WriteLine($"Antigüedad en la empresa: {empleados[i].AñosAntiguedad()} años");
        Console.WriteLine($"Edad: {empleados[i].EdadEmpleado()}");
        Console.WriteLine($"Años faltantes para jubilarse: {empleados[i].AñosParaJubilacion()}");
        Console.WriteLine($"Salario: ${empleados[i].ObtenerSalario()}");
        Console.WriteLine("\n-----------------------------\n");
        break; // 🔹 Esto asegura que solo muestre uno (el primero que coincida)
    }
}

Console.WriteLine($"\nMonto total en concepto de salarios: {sueldoTotal}");
