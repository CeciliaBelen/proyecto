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
            objEntidadAlumno.DNI = 1267888;
            objEntidadAlumno.Apellido = "Rodriguez Perez";
            objEntidadAlumno.Nombre = "Flor";
            Logica.Alumno objLogicaAlumno = new Logica.Alumno();
            objLogicaAlumno.Agregar(objEntidadAlumno);
            Console.WriteLine("Alumno agregado!");
            Console.ReadKey();
        }
    }
}
