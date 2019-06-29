using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentacionConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Entidades.Alumno objEntidadAlumno = new Entidades.Alumno();
            //Pedir datos al usuario
            Console.Write("Ingrese su DNI: ");
            objEntidadAlumno.DNI = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese su nombre: ");
            objEntidadAlumno.Nombre = Console.ReadLine();
            Console.Write("Ingrese su apellido: ");
            objEntidadAlumno.Apellido = Console.ReadLine();

            Logica.Alumno objLogicaAlumno = new Logica.Alumno();
            objLogicaAlumno.Agregar(objEntidadAlumno);
            Console.WriteLine("¡Alumno agregado!");
            Console.ReadKey();
        }
    }
}
