using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTeachers
{
    class Program
    {
        static void Main(string[] args)
        {
            Entidades.Profesor objEntidadProfesor = new Entidades.Profesor();
            Console.Write("Ingrese su apellido: ");
            objEntidadProfesor.Apellido = Console.ReadLine();
            Console.Write("Ingrese su nombre: ");
            objEntidadProfesor.Nombre = Console.ReadLine();
            Console.Write("Ingrese su mail: ");
            objEntidadProfesor.Mail = Console.ReadLine();

            Logica.Profesor objLogicaProfesor = new Logica.Profesor();
            objLogicaProfesor.Agregar(objEntidadProfesor);
            Console.WriteLine("¡Profesor agregado!");
            Console.ReadKey();
        }
    }
}
