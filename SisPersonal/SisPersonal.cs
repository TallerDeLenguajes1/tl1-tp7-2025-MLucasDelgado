namespace Personal
{

    public enum Cargos
    {
        AuxiliarAdministrativo,
        Ingeniero,
        Especialista,
        Investigador    
    }

    public class Empleado
    {
        private string nombre;
        private string apellido;
        private DateTime fechaNacimiento;
        private char estadoCivil;
        private DateTime fechaIngreso;
        private double sueldoBasico;
        private Cargos cargo;

        // PROPIEDADES
        public string Nombre
        {
            get { return nombre; } // permite leer el valor
            set { nombre = value; } // permite escribir un nuevo valor
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }

        public char EstadoCivil
        {
            get { return estadoCivil; }
            set { estadoCivil = value; }
        }

        public DateTime FechaIngreso
        {
            get { return fechaIngreso; }
            set { fechaIngreso = value; }
        }

        public double SalarioBasico
        {
            get { return sueldoBasico; }
            set { sueldoBasico = value; }
        }

        public Cargos Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }

        // METODOS
        public int AñosAntiguedad()
        {
            int antiguedad = DateTime.Today.Year - fechaIngreso.Year;

            if (fechaIngreso > DateTime.Today.AddYears(-antiguedad))
            {
                antiguedad--;
            }

            return antiguedad;
        }

        public int EdadEmpleado()
        {
            int edad = DateTime.Today.Year - fechaNacimiento.Year;
            // por si aun no cumple-años, por ejemplo (22/06/2001 > 22/05/2001, en este caso es verdadero)
            if (fechaNacimiento > DateTime.Today.AddYears(-edad))
            {
                edad--;
            }
            return edad;
        }

        public int AñosParaJubilacion()
        {
            int edadActual = EdadEmpleado();
            int añosRestantes = 65 - edadActual;

            return añosRestantes > 0 ? añosRestantes : 0;
        }
    }
}