using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Prueba_SQL_conThiago
{
    public class Sql
    {
        #region Campos
        SqlCommand sqlCommand;
        SqlConnection sqlConnection;
        #endregion

        public Sql()
        {
            //Inicializo la conexión
            SqlConnectionStringBuilder sqlBuilder = new SqlConnectionStringBuilder();
            sqlBuilder.DataSource = @".\SQLEXPRESS";
            sqlBuilder.IntegratedSecurity = true;
            sqlBuilder.InitialCatalog = "prueba-thiago";
            this.sqlConnection = new SqlConnection(sqlBuilder.ToString());
            //------------------------------------------

            //Inicializo el comando
            sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = System.Data.CommandType.Text;
        }

        public void Guardar(List<Persona> p)
        {
            try
            {
                sqlConnection.Open();
                foreach (Persona item in p)
                {
                    sqlCommand.CommandText = $"INSERT INTO dbo.prueba_nombre_edad (nombre,edad) VALUES ('{item.Nombre}',{item.Edad})";

                    sqlCommand.ExecuteNonQuery();
                }
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message,exc);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public void Leer(out List<Persona> p)
        {
            List<Persona> p2 = new List<Persona>();
            Persona q;
            string nombreAux = "";
            int edadAux = 0;

            sqlCommand.CommandText = @"SELECT * FROM dbo.prueba_nombre_edad";

            try
            {
                sqlConnection.Open();
                SqlDataReader oDr = this.sqlCommand.ExecuteReader();
                while (oDr.Read())
                {
                    nombreAux = oDr["nombre"].ToString();
                    edadAux = (int)oDr["edad"];
                    q = new Persona(nombreAux, edadAux);
                    p2.Add(q);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                sqlConnection.Close();
            }
            p = p2;

        }
    }
}
