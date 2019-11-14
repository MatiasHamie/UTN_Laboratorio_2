using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace Entidades
{
    public class Dao<T> : IArchivos<T>
    {
        #region Atributos
        SqlConnection _conexion;
        SqlCommand _comando;
        string conectionStr;
        #endregion

        #region Constructor
        public Dao()
        {
            this.conectionStr = @"Data Source=.\SQLEXPRESS; Initial Catalog= votacion-sp-2018; Integrated Security = True";
            this._conexion = new SqlConnection(conectionStr);
            this._comando = new SqlCommand();
            this._comando.CommandType = System.Data.CommandType.Text;
            this._comando.Connection = this._conexion;
        }
        #endregion

        #region Métodos
        public SqlDataReader Consulta(string comando)
        {
            SqlDataReader oDr;
            this._comando.CommandText = comando;

            try
            {
                this._conexion.Open();
                oDr = _comando.ExecuteReader();

            }
            catch (Exception e)
            {
                throw e;
            }

            //Aca habia un finally con this._conexion.Close()

        }

        public T Leer(string rutaArchivo)
        {
            
            throw new NotImplementedException();
        }

        public bool Guardar(string rutaArchivo, T objeto)
        {
            throw new NotImplementedException();
        }
        #endregion

    }
        
}
