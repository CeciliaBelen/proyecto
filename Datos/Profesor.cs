using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class Profesor
    {
        public void Agregar(Entidades.Profesor profesor)
        {
            string strConnection = @"Server=CPX-DRG65AZ7G7H\TRAINING;database=tecno;Integrated Security=true";
            string strSQL = "insert into Profesores(Apellido,Nombre,Mail) values(@apellido,@nombre,@mail)";
            SqlConnection objConnection = new SqlConnection();
            objConnection.ConnectionString = strConnection;
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandText = strSQL;
            objCommand.Connection = objConnection;

            objCommand.Parameters.AddWithValue("@apellido", profesor.Apellido);
            objCommand.Parameters.AddWithValue("@nombre", profesor.Nombre);
            objCommand.Parameters.AddWithValue("@mail", profesor.Mail);

            objConnection.Open();
            objCommand.ExecuteNonQuery();
            objConnection.Close();
        }
    }
}
