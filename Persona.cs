using System;

namespace ejerciciopersonal
{
    class Persona{

        public string nombre { set; get; }
        public string apellido { set; get; }
        public int numerodeidentificacion { set; get; }
        public string estadocivilac { set; get; }

        public Persona(String Nombre, String apellidos, int numero, String estado)
        {
            this.nombre = Nombre;
            this.apellido = apellidos;
            this.numerodeidentificacion = numero;
            this.estadocivilac = estado; 
        }

        public void cambiodeestado()
        {
            String nuevoestado;
            do
            { 
             Console.WriteLine("Ingrese su nuevo Estado Civil");
             Console.WriteLine("*soltero ");
             Console.WriteLine("*casado ");
             Console.WriteLine("*viudo ");

                nuevoestado = Console.ReadLine();

            if (nuevoestado == "soltero") {
                estadocivilac = nuevoestado;
                Console.WriteLine("Cambiado correctamente");
            }
            else if (nuevoestado == "casado") {
                estadocivilac = nuevoestado;
                Console.WriteLine("Cambiado correctamente");
            }
            else if (nuevoestado == "viudo") {
                estadocivilac = nuevoestado;
                Console.WriteLine("Cambiado correctamente");
            } else {
                    Console.WriteLine("Estado civil Incorrecto");
                    Console.WriteLine("Ingrese el nuevo Estado Civil");
                    Console.WriteLine("*soltero ");
                    Console.WriteLine("*casado ");
                    Console.WriteLine("*viudo ");
                    nuevoestado = Console.ReadLine();
                    Console.WriteLine("Cambiado correctamente");

                }
            } while(nuevoestado != null && nuevoestado == "soltero" && nuevoestado == "casado" && nuevoestado == "viudo");
        }

    }
}
