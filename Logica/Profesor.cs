namespace Logica
{
    public class Profesor
    {
        public void Agregar(Entidades.Profesor pProfesor)
        {
            Datos.Profesor objProfesor = new Datos.Profesor();
            objProfesor.Agregar(pProfesor);
        }
    }
}
