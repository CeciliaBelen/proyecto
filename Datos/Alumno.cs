using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class Alumno
    {
        //Método Agregar
        public void Agregar(Entidades.Alumno alumno)
        {
            string strConexion = @"Server=CPX-DRG65AZ7G7H\TRAINING;database=tecno;Integrated Security=true";
            string strSQL = "insert into Alumnos(DNI,Apellido,Nombre) values (@dni,@apellido,@nombre)";
            SqlConnection objConexion = new SqlConnection();
            objConexion.ConnectionString = strConexion;
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandText = strSQL;
            objCommand.Connection = objConexion;
            //Parámetros
            objCommand.Parameters.AddWithValue("@dni", alumno.DNI);
            objCommand.Parameters.AddWithValue("@apellido", alumno.Apellido);
            objCommand.Parameters.AddWithValue("@nombre", alumno.Nombre);
            //Abrir la conexión
            objConexion.Open();
            objCommand.ExecuteNonQuery();
            objConexion.Close();
        }
        public DataTable TraerTodos()
        {
            DataTable dt = new DataTable();
            string strConexion = @"Server=CPX-DRG65AZ7G7H\TRAINING;database=tecno;Integrated Security=true";
            string strSQL = "select * from Alumnos";
            SqlDataAdapter objDa = new SqlDataAdapter(strSQL,strConexion);
            objDa.Fill(dt);
            return dt;
        }

    }
}
