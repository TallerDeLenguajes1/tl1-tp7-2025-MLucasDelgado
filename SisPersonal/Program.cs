using Personal;

Empleado e = new Empleado();

e.Nombre = "Lucas"; // Usa el set → asigna valor
e.Apellido = "Delgado";

Console.WriteLine("Ingrese la fecha cuándo ingreso a la compañía (formato AAAA-MM-DD): ");
e.FechaIngreso = DateTime.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la fecha de nacimiento (formato AAAA-MM-DD): ");
e.FechaNacimiento = DateTime.Parse(Console.ReadLine());

Console.WriteLine($"La edad del empleado {e.Nombre} {e.Apellido} es de {e.EdadEmpleado()} años.");
Console.WriteLine($"La antigüedad en la empresa es de {e.AñosAntiguedad()} años.");
Console.WriteLine($"Le faltan {e.AñosParaJubilacion()} años para jubilarse.");
