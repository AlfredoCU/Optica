using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using Optica.Properties;
using System.Configuration;

namespace Optica.Clases
{
    class Producto
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataTable dt;
        DataSet ds;

        public static string obtenerString()
        {
            return Settings.Default.Setting;
        }

        public Producto(string mensajeConexion)
        {
            mensajeConexion = obtenerString();
            cn = new SqlConnection(mensajeConexion);
            cn.Open();
        }

        //PRODUCTO
        public string InsertarProducto(int idProducto, string nombreProducto, string marcaProducto,
            string descripcionProducto, float costoProducto)
        {
            string salida = "Se insertó la información correctamente";
            MessageBox.Show(salida, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            try
            {
                cmd = new SqlCommand("INSERT INTO PRODUCTO ([Id Producto], Nombre, Marca, Descripcion, Costo) VALUES(" + idProducto + ", '" + nombreProducto + "', '" + marcaProducto + "','" + descripcionProducto + "', " + costoProducto + ")", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se conectó: " + ex.ToString();
                MessageBox.Show(salida, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return salida;
        }

        public int ProductoRegistrado(int idProducto)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("SELECT * FROM PRODUCTO WHERE [Id Producto]=" + idProducto + "", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar la información: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return contador;
        }

        public void CargarProductoVer(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("SELECT * FROM PRODUCTO", cn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar la tabla de consultar: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CargarProducto(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("SELECT * FROM PRODUCTO WHERE ([Id Producto] BETWEEN 1 AND 1000000)", cn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar la tabla de consultar: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LlenarTexBoxConsultaProducto(int idProducto, TextBox txtNombreProducto, 
            TextBox txtMarcaProducto, RichTextBox rtbDescripcionProducto, TextBox txtCostoProducto)
        {
            try
            {
                cmd = new SqlCommand("SELECT * FROM PRODUCTO WHERE [Id Producto]=" + idProducto + "", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtNombreProducto.Text = dr["Nombre"].ToString();
                    txtMarcaProducto.Text = dr["Marca"].ToString();
                    rtbDescripcionProducto.Text = dr["Descripcion"].ToString();
                    txtCostoProducto.Text = dr["Costo"].ToString();
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar los campos: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string ActualizarProducto(int idProducto, string nombreProducto, string marcaProducto,
            string descripcionProducto, float costoProducto)
        {
            string salida = "Se actualizaron los datos";
            MessageBox.Show(salida, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            try
            {
                cmd = new SqlCommand("UPDATE PRODUCTO SET Nombre = '" + nombreProducto + "', Marca = '" + marcaProducto + "', Descripcion = '" + descripcionProducto + "', Costo = " + costoProducto + " WHERE [Id Producto] =" + idProducto + "", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se actualizo: " + ex.ToString();
                MessageBox.Show(salida, "Error de actualizar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return salida;
        }

        public DataTable BuscarProducto(string nombre)
        {
            cmd = new SqlCommand(string.Format("SELECT * FROM PRODUCTO WHERE Nombre LIKE '%{0}%'", nombre), cn);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "tabla");
            return ds.Tables["tabla"];
        }

        public bool EliminarProducto(string idProducto)
        {
            cmd = new SqlCommand(string.Format("DELETE FROM PRODUCTO WHERE [Id Producto]= {0}", idProducto), cn);
            int filasafectadas = cmd.ExecuteNonQuery();
            if (filasafectadas > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}