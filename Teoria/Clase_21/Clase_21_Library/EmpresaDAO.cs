using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace Clase_21
{
    public static class EmpresaDAO
    {
        #region Atributos
        private static SqlConnection _conexion;
        private static SqlCommand _comando;
        #endregion

        #region Constructores
        static EmpresaDAO()
        {
            // CREO UN OBJETO SQLCONECTION
            EmpresaDAO._conexion = new SqlConnection(Properties.Settings.Default.CadenaConexion);
            // CREO UN OBJETO SQLCOMMAND
            EmpresaDAO._comando = new SqlCommand();
            // INDICO EL TIPO DE COMANDO
            EmpresaDAO._comando.CommandType = System.Data.CommandType.Text;
            // ESTABLEZCO LA CONEXION
            EmpresaDAO._comando.Connection = EmpresaDAO._conexion;
        }
        #endregion

        #region Métodos

        #region Getters
        public static Empresa ObtenerEmpresa()
        {
            bool TodoOk = false;
            Empresa empresa = null;

            try
            {
                // LE PASO LA INSTRUCCION SQL
                EmpresaDAO._comando.CommandText = "SELECT TOP 1 id,razonSocial,direccion,ganancias FROM Empresas";

                // ABRO LA CONEXION A LA BD
                EmpresaDAO._conexion.Open();

                // EJECUTO EL COMMAND                 
                SqlDataReader oDr = EmpresaDAO._comando.ExecuteReader();

                // MIENTRAS TENGA REGISTROS...
                if (oDr.Read())
                {
                    // ACCEDO POR NOMBRE O POR INDICE
                    empresa = new Empresa(int.Parse(oDr["id"].ToString()), oDr["razonSocial"].ToString(), oDr["direccion"].ToString(), float.Parse(oDr["ganancias"].ToString()));
                }

                //CIERRO EL DATAREADER
                oDr.Close();

                TodoOk = true;
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                if (TodoOk)
                    EmpresaDAO._conexion.Close();
            }
            return empresa;
        }
        #endregion

        #region Insertar Empresa
        public static bool InsertarEmpresa(Empresa e)
        {
            string sql = "INSERT INTO Empresas (razonSocial,direccion,ganancias) VALUES(";
            sql = sql + "'" + e.RazonSocial + "','" + e.Direccion + "'," + e.Ganancias.ToString().Replace(",",".") + ")";

            return EjecutarNonQuery(sql);

        }
        #endregion

        #region Modificar Empresa
        public static bool ModificarEmpresa(Empresa e)
        {
            string sql = "UPDATE Empresas SET razonSocial = '" + e.RazonSocial + "', direccion = '";
            sql = sql + e.Direccion + "', ganancias = " + e.Ganancias.ToString().Replace(",", ".") + " WHERE id = " + e.ID.ToString();

            return EjecutarNonQuery(sql);
        }
        #endregion

        #region Eliminar Empresa
        public static bool EliminarEmpresa(Empresa e)
        {

            string sql = "DELETE FROM Empresas WHERE id = " + e.ID.ToString();

            return EjecutarNonQuery(sql);
        }
        #endregion

        private static bool EjecutarNonQuery(string sql)
        {
            bool todoOk = false;
            try
            {
                // LE PASO LA INSTRUCCION SQL
                EmpresaDAO._comando.CommandText = sql;

                // ABRO LA CONEXION A LA BD
                EmpresaDAO._conexion.Open();

                // EJECUTO EL COMMAND
                EmpresaDAO._comando.ExecuteNonQuery();

                todoOk = true;
            }
            catch (Exception e)
            {
                todoOk = false;
            }
            finally
            {
                if (todoOk)
                    EmpresaDAO._conexion.Close();
            }
            return todoOk;
        }

        #endregion
    }
}
