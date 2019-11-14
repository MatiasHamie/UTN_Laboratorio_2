using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace Clase_21
{
    public static class EmpleadoDAO
    {
        #region Atributos
        private static SqlConnection _conexion;
        private static SqlCommand _comando;
        #endregion

        #region Constructores
        static EmpleadoDAO()
        {
            // CREO UN OBJETO SQLCONECTION
            EmpleadoDAO._conexion = new SqlConnection(Properties.Settings.Default.CadenaConexion);
            // CREO UN OBJETO SQLCOMMAND
            EmpleadoDAO._comando = new SqlCommand();
            // INDICO EL TIPO DE COMANDO
            EmpleadoDAO._comando.CommandType = System.Data.CommandType.Text;
            // ESTABLEZCO LA CONEXION
            EmpleadoDAO._comando.Connection = EmpleadoDAO._conexion;
        }
        #endregion

        #region Métodos

        #region Getters
        public static List<Empleado> ObtenerListaEmpleados()
        {
            bool TodoOk = false;
            List<Empleado> empleados = null;

            try
            {
                // LE PASO LA INSTRUCCION SQL
                EmpleadoDAO._comando.CommandText = "SELECT id,legajo,salario,puestoJerarquico,nombre,apellido FROM Empleados";

                // ABRO LA CONEXION A LA BD
                EmpleadoDAO._conexion.Open();

                // EJECUTO EL COMMAND                 
                SqlDataReader oDr = EmpleadoDAO._comando.ExecuteReader();

                // MIENTRAS TENGA REGISTROS...
                while (oDr.Read())
                {
                    // ACCEDO POR NOMBRE
                    Empleado.EPuestoJerarquico puesto;
                    if (!Enum.TryParse<Empleado.EPuestoJerarquico>(oDr["puestoJerarquico"].ToString(), out puesto))
                    {
                        puesto = Empleado.EPuestoJerarquico.Sistemas;
                    }
                    empleados.Add(new Empleado(int.Parse(oDr["id"].ToString()), oDr["nombre"].ToString(), oDr["apellido"].ToString(), oDr["legajo"].ToString(), puesto, int.Parse(oDr["salario"].ToString())));
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
                    EmpleadoDAO._conexion.Close();
            }
            return empleados;
        }
        public static Empleado ObtenerEmpleado(Empleado e)
        {
            bool TodoOk = false;
            Empleado empleado = null;

            try
            {
                // LE PASO LA INSTRUCCION SQL
                EmpleadoDAO._comando.CommandText = "SELECT id,legajo,salario,puestoJerarquico,nombre,apellido FROM Empleados WHERE id = " + e.ID;

                // ABRO LA CONEXION A LA BD
                EmpleadoDAO._conexion.Open();

                // EJECUTO EL COMMAND                 
                SqlDataReader oDr = EmpleadoDAO._comando.ExecuteReader();

                // MIENTRAS TENGA REGISTROS...
                if (oDr.Read())
                {
                    // ACCEDO POR NOMBRE
                    Empleado.EPuestoJerarquico puesto;
                    if (!Enum.TryParse<Empleado.EPuestoJerarquico>(oDr["puestoJerarquico"].ToString(), out puesto))
                    {
                        puesto = Empleado.EPuestoJerarquico.Sistemas;
                    }
                    empleado = new Empleado(int.Parse(oDr["id"].ToString()), oDr["nombre"].ToString(), oDr["apellido"].ToString(), oDr["legajo"].ToString(), puesto, int.Parse(oDr["salario"].ToString()));
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
                    EmpleadoDAO._conexion.Close();
            }
            return empleado;
        }
        #endregion

        #region Insertar Empleado
        public static bool InsertarEmpleado(Empleado e)
        {
            string sql = "INSERT INTO Empleados (legajo,salario,puestoJerarquico,nombre,apellido) VALUES(";
            sql = sql + "'" + e.Legajo + "'," + e.Salario + "," + (int)e.PuestoJerarquico + ",'" + e.Nombre + "','" + e.Apellido + "')";

            return EjecutarNonQuery(sql);

        }
        #endregion

        #region Modificar Empleado
        public static bool ModificarEmpleado(Empleado e)
        {
            string sql = "UPDATE Empleados SET legajo = '" + e.Legajo + "', nombre = '" + e.Nombre + "', apellido = '" + e.Apellido + "',";
            sql = sql + " salario = " + e.Salario + ", puestoJerarquico = " + (int)e.PuestoJerarquico + " WHERE id = " + e.ID.ToString();

            return EjecutarNonQuery(sql);
        }
        #endregion

        #region Eliminar Empleado
        public static bool EliminarEmpleado(Empleado e)
        {

            string sql = "DELETE FROM Empleados WHERE id = " + e.ID.ToString();

            return EjecutarNonQuery(sql);
        }
        #endregion

        private static bool EjecutarNonQuery(string sql)
        {
            bool todoOk = false;
            try
            {
                // LE PASO LA INSTRUCCION SQL
                EmpleadoDAO._comando.CommandText = sql;

                // ABRO LA CONEXION A LA BD
                EmpleadoDAO._conexion.Open();

                // EJECUTO EL COMMAND
                EmpleadoDAO._comando.ExecuteNonQuery();

                todoOk = true;
            }
            catch (Exception e)
            {
                todoOk = false;
            }
            finally
            {
                if (todoOk)
                    EmpleadoDAO._conexion.Close();
            }
            return todoOk;
        }

        #endregion
    }
}
