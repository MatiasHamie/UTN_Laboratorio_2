using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using Entidades;

namespace Archivos
{
    public class Sql:IArchivo<List<Patente>>
    {
        #region Campos
        private SqlConnection connection;
        private SqlCommand command;
        #endregion

        public Sql()
        {
            SqlConnectionStringBuilder strConnection = new SqlConnectionStringBuilder();
            strConnection.DataSource = @".\SQLEXPRESS";
            strConnection.IntegratedSecurity = true;
            strConnection.InitialCatalog = "patentes-sp-2018";
            this.connection = new SqlConnection(strConnection.ToString());

            this.command = new SqlCommand();
            this.command.Connection = this.connection;
            this.command.CommandType = CommandType.Text;
        }

        public void Guardar(string archivo, List<Patente> datos)
        {
            try
            {
                this.connection.Open();
                foreach (Patente patente in datos)
                {
                    this.command.CommandText = $"INSERT INTO tabla {archivo} VALUES('{patente.CodigoPatente}')";
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception exc)
            {
                throw new Exception("No se pudo hacer el INSERT", exc);
            }
            finally
            {
                this.connection.Close();
            }
        }

        public void Leer(string archivo, out List<Patente> datos)
        {
            //Ojo con trabajar directamente con la QUEUE, inicializo una nueva y cuando termino las igualo
            List<Patente> aux = new List<Patente>();
            //Asi como tengo una cola, tengo que crear una patente antes de agregarla
            Patente AuxPatente = new Patente();
            string AuxCodigoPatente = "";

            //Lo uso una vez que abro la conexion y lo igualo a this.command.ExecuteReader();
            SqlDataReader oDr;
            this.command.CommandText = $"SELECT * FROM {archivo}";

            try
            {
                this.connection.Open();
                oDr = this.command.ExecuteReader();

                while (oDr.Read())
                {
                    //Uso el ODR como un indexer que le paso la columna y me devuelve de a una patente a la vez
                    AuxCodigoPatente = oDr["patente"].ToString();
                    AuxPatente.CodigoPatente = AuxCodigoPatente;
                    aux.Add(AuxPatente);
                }

                //Una vez que termine de iterar, igualo las colas
                datos = aux;

            }
            catch (Exception exc)
            {
                datos = default;
                throw new Exception("Error al querer consultar BD", exc);
            }
            finally
            {
                this.connection.Close();
            }
        }
    }
}
