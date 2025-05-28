namespace EspacioCalculadora
{
    public class Calculadora
    {
        private double dato;

        // Objeto Constructor, cuando creo la clase en new, el valor que mando se manda aca, sino le mando un parametro lo igualo a 0.
        public Calculadora(double dato) {
            this.dato = dato;
        }

        public void Sumar(double termino)
        {
            dato += termino;
        }

        public void Restar(double termino)
        {
            dato -= termino;
        }

        public void Multiplicar(double termino)
        {
            dato *= termino;
        }
        public void Dividir(double termino)
        {
            if (termino != 0) dato = dato / termino;
            else Console.WriteLine("No se puede dividir en 0");
        }

        public void Limpiar()
        {
            dato = 0;
        }
        public double GetResultado()
        {
            return dato;
        }
    }

}

