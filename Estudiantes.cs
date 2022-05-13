using System;

namespace ejerciciopersonal
{
    class Estudiantes:Persona
    {

        public string curso { set; get; }

        public Estudiantes(String Curso, String Nombre, String apellidos, int numero, String estado) :base(Nombre, apellidos, numero, estado)
        {
            this.curso = Curso;
        }
        public void imprimir()
        {
            Console.WriteLine(" Matriculacion de Estudiantes");
            Console.WriteLine("");
            Console.WriteLine("Curso Asignado: " + curso);
            Console.WriteLine("");
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
            Console.WriteLine("Si desea cambiar el curso utilize Ingrese: 1");
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
                    cursonuevo();
                    break;
                case "2":
                    cambioestado();
                    break;
                case "salir":
                    Console.WriteLine("....");
                    break;

            }

        }
        public void cursonuevo()
        {
            String curso_new;
            Console.WriteLine("Ingrese el nuevo Curso");
            curso_new = Console.ReadLine();
            Console.WriteLine("Curso cambiado exitosamente");
            curso = curso_new;
        }
    }
}
