using LinqToSqlStringBuilder;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


namespace Pizzeria.Models
{
    public class CheckUserBD
    {
        public int? ComproveUserPasswordBD(String Email, String Contraseña)
        {
            int? rownumber;
            SqlConexion conexion = null;
            SqlCommand command = null;
            
            if(Email==null || Email==""){
                throw new Exception("Email no valido");
            }
            if (Contraseña == null || Contraseña == "")
            {
                throw new Exception("Contraseña no valida");
            }
               try
              {          
                conexion = new SqlConexion(ListConexion.GetDataSource());            
                conexion.Open();
                command = conexion.CreateCommand();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "Select Count(*) From Usuario Where Email=@Email AND Contraseña=@Contraseña";
                command.Parameters.Add(new SqlParameter("@Email",Email));
                command.Parameters.Add(new SqlParameter("@Contraseña", Contraseña));
                rownumber = command.ExecuteScalar() as int?;
                
            }
            catch (SqlException)
            {
                throw new Exception("Error en la consulta");
            }
            catch (Exception)
            {
                throw new Exception("Error en la consulta");
            }
            finally
            {
                command.Dispose();
                conexion.Close();
            }
    
            return rownumber;
        }
    }
}