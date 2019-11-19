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
    public class Sql:IArchivo
    {
        #region Campos
        private SqlCommand comando;
        private SqlConnection conexion;
        #endregion

        #region Métodos

        #region Constructores
        public Sql()
        {
            SqlConnectionStringBuilder strConexion = new SqlConnectionStringBuilder();
            strConexion.InitialCatalog = "patentes-sp-2018";
            strConexion.IntegratedSecurity = true;
            strConexion.DataSource = @".\SQLEXPRESS";
            conexion = new SqlConnection(strConexion.ToString());

            comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.Connection = conexion;
        }
        #endregion

        public void Guardar(string tabla, Queue<Patente> datos)
        {
            
        }
        public void Leer(string tabla,out Queue<Patente> datos)
        {
            comando.CommandText = "SELECT (patente,tipo) FROM Patentes";
            SqlDataReader oDr = this.comando.ExecuteReader();

            while (oDr.Read())
            {
                string aux = oDr["tipo"].ToString();
            }
        }
        #endregion
    }
}
