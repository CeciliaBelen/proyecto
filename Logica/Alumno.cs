namespace Logica
{
    public class Alumno
    {
        //Métodos
        /// <summary>
        /// Llamado al método agregar datos
        /// Creado por Cecilia
        /// Fecha de Creación: 21/06/2019
        /// </summary>
        /// <param name="pAlumno"></param>
        public void Agregar(Entidades.Alumno pAlumno)
        {
            //TODO: Llamar a métodos de la capa de Datos
            Datos.Alumno objAlumno = new Datos.Alumno();
            objAlumno.Agregar(pAlumno);
        }
    }
}
