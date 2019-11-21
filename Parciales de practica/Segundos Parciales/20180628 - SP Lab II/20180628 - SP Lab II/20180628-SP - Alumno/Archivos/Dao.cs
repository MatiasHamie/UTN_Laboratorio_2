using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    public class Dao: IArchivos<Votacion>
    {
        #region Campos
        SqlCommand sqlCommand;
        SqlConnection sqlConnection;
        #endregion

        public Dao()
        {
            //Inicializo la conexión
            SqlConnectionStringBuilder sqlBuilder = new SqlConnectionStringBuilder();
            sqlBuilder.DataSource = @".\SQLEXPRESS";
            sqlBuilder.IntegratedSecurity = true;
            sqlBuilder.InitialCatalog = "votacion-sp-2018";
            this.sqlConnection = new SqlConnection(sqlBuilder.ToString());
            //------------------------------------------

            //Inicializo el comando
            sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = System.Data.CommandType.Text;
        }

        public bool Guardar(string rutaArchivo, Votacion Objeto)
        {
            string nombreLey = Objeto.NombreLey;
            short afirmativos = Objeto.ContadorAfirmativo;
            short negativos = Objeto.ContadorNegativo;
            short abstenciones = Objeto.ContadorAbstencion;
            bool retorno = true;

            try
            {
                sqlConnection.Open();
                //Ojo, aca va la tabla, no la BD!
                sqlCommand.CommandText = $"INSERT INTO dbo.Votaciones" +
                    $" (nombreLey,afirmativos,negativos,abstenciones,nombreAlumno)" +
                    $" VALUES ('{nombreLey}',{afirmativos},{negativos},{abstenciones},'{"Hamie Matias"}')";

                sqlCommand.ExecuteNonQuery();
              
            }
            catch (Exception exc)
            {
                retorno = false;
                throw new Exception(exc.Message, exc);
            }
            finally
            {
                sqlConnection.Close();                
            }

            return retorno;
        }

        public Votacion Leer(string rutaArchivo)
        {
            throw new NotImplementedException();
        }
    }
}
