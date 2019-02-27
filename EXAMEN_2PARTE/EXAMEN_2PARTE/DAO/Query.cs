using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

using EXAMEN_2PARTE.DTO;
using System.Windows.Forms;

namespace EXAMEN_2PARTE.DAO
{
    class Query
    {
        private MySqlConnection conexión;
        public Query()
        {
            conexión = SINGLETON.Instance.SqlConnection;
        }
        public DataSet Mostrar()
        {
            var salida = new DataSet();

            try
            {
                conexión.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("select * from exa;", conexión);
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
                mySqlDataAdapter.Fill(salida);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conexión.Close();
            return salida;
        }
        public void Insertar(exa e)
        {
            try
            {
                conexión.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexión;

                cmd.CommandText = "examenInsert";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@_Fecha", e.Fecha);
                cmd.Parameters["@_Fecha"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@_Dia", e.Dia);
                cmd.Parameters["@_Dia"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@_Mes", e.Mes);
                cmd.Parameters["@_Mes"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@_Codigo_Ver", e.Codigo_Ver);
                cmd.Parameters["@_Codigo_Ver"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@_Vendedor", e.Vendedor);
                cmd.Parameters["@_Vendedor"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@_Producto", e.Producto);
                cmd.Parameters["@_Producto"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@_Nombre_Producto", e.Nombre_Producto);
                cmd.Parameters["@_Nombre_Producto"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@_Linea", e.Linea);
                cmd.Parameters["@_Linea"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@_Nombre_Linea", e.Nombre_Linea);
                cmd.Parameters["@_Nombre_Linea"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@_Cliente", e.Cliente);
                cmd.Parameters["@_Cliente"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@_Precio", e.Precio);
                cmd.Parameters["@_Precio"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@_cantidad", e.cantidad);
                cmd.Parameters["@_cantidad"].Direction = ParameterDirection.Input;

                cmd.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conexión.Close();
        }

        public void Actualizar(exa e)
        {
            try
            {
                conexión.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexión;

                cmd.CommandText = "examenUpdate";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@_Fecha", e.Fecha);
                cmd.Parameters["@_Fecha"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@_Dia", e.Dia);
                cmd.Parameters["@_Dia"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@_Mes", e.Mes);
                cmd.Parameters["@_Mes"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@_Codigo_Ver", e.Codigo_Ver);
                cmd.Parameters["@_Codigo_Ver"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@_Vendedor", e.Vendedor);
                cmd.Parameters["@_Vendedor"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@_Producto", e.Producto);
                cmd.Parameters["@_Producto"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@_Nombre_Producto", e.Nombre_Producto);
                cmd.Parameters["@_Nombre_Producto"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@_Linea", e.Linea);
                cmd.Parameters["@_Linea"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@_Nombre_Linea", e.Nombre_Linea);
                cmd.Parameters["@_Nombre_Linea"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@_Cliente", e.Cliente);
                cmd.Parameters["@_Cliente"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@_Precio", e.Precio);
                cmd.Parameters["@_Precio"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@_cantidad", e.cantidad);
                cmd.Parameters["@_cantidad"].Direction = ParameterDirection.Input;

                cmd.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conexión.Close();
        }
        public void Eliminar(int Codigo_Ver)
        {
            try
            {
                conexión.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexión;

                cmd.CommandText = "examenDelete";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@_Codigo_Ver", Codigo_Ver);
                cmd.Parameters["@_Codigo_Ver"].Direction = ParameterDirection.Input;

                cmd.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conexión.Close();
        }




    }
        
    
}
