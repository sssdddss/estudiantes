
namespace ejerciciopersonal
{
    class Program
    {
        public static void Main(string[] args)
        {
            Empleados empleados = new Empleados("Bar de comida", 2022, "Jose", "Arteaga", 1, "Soltero");
            empleados.imprimir();
            Estudiantes estudiante = new Estudiantes("B455", "Felipe", "Mendoza", 2, "Soltero");
            estudiante.imprimir();
            Personal personal = new Personal("Secretaria", "Diana", "Lopez", 3, "Casada");
            personal.imprimir();
            Profesores profesores = new Profesores("Informatica", "Marcos", "Macias", 3, "viudo");
            profesores.imprimir();
        }
    }
    }