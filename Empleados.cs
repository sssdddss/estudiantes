using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciopersonal
{
    class Empleados : Persona
    {

        public string numerodespacho { set; get; }
        public int año { set; get; }

        public Empleados(String despacho,int Año, String Nombre, String apellidos, int numero, String estado) : base(Nombre, apellidos, numero, estado)
        {
            this.numerodespacho = despacho;
            this.año = Año;
        }

        public void imprimir()
        {         
            Console.WriteLine(" Empleados del trabajo");
            Console.WriteLine("");
            Console.WriteLine("Numero de Despacho: " + numerodespacho);
            Console.WriteLine("");
            Console.WriteLine("Año de incorporacion: " + año);
            Console.WriteLine("Nombre: " + nombre + " - Apellido: " + apellido);
            Console.WriteLine("Numero de Identificacion: " + numero_identificacion);
            Console.WriteLine("Estado Civil: " + estadocivilac);
            Console.WriteLine("");
            opcioness();
            Console.WriteLine("");
        }

            public void opciones()
            {
                String options;
                Console.WriteLine("Opciones alternas:");
                Console.WriteLine("Si desea cambiar el despacho utilize Ingrese: 1");
                Console.WriteLine("Si desea cambiar el Estado Civil Ingrese: 2");
                Console.WriteLine("Si desea salir utilize: salir ");
                options = Console.ReadLine();
                cambio(options);
            }
            public void cambio(String cambios)
            {

                switch (cambios.ToString())
                {
                    case "1":
                    cambioespacho();
                        break;
                    case "2":
                        cambiodeestado();
                        break;
                    case "salir":
                        Console.WriteLine("....");
                        break;

                }

            }
            public void cambioespacho()
        {
            String espacho_new;
            Console.WriteLine("Ingrese el nuevo espacho");
            espacho_new = Console.ReadLine();
            Console.WriteLine("espacho cambiado exitosamente");
            numerodespacho = espacho_new;
        }
    }

}
