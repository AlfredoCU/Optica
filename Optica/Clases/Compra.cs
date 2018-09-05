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
    class Compra
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

        public Compra(string mensajeConexion)
        {
            mensajeConexion = obtenerString();
            cn = new SqlConnection(mensajeConexion);
            cn.Open();
        }

        //COMPRA
        public string InsertarCompra(int idCompra, int idExamen, int idProducto, string fechaCompra, float total)
        {
            string salida = "Se insertó la información correctamente";
            MessageBox.Show(salida, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            try
            {
                cmd = new SqlCommand("INSERT INTO COMPRA ([Id Compra], [Id Examen], [Id Producto], [Fecha de Compra], Total) VALUES(" + idCompra + ", " + idExamen + ", " + idProducto + ", '" + fechaCompra + "', " + total + ")", cn);
                //cmd = new SqlCommand("UPDATE PRODUCTO  SET Stock = Stock - Cantidad FROM PRODUCTO JOIN COMPRA ON COMPRA.[Id Compra] = " + idCompra + "", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se conectó: " + ex.ToString();
                MessageBox.Show(salida, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return salida;
        }

        public int CompraRegistrado(int idCompra)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("SELECT * FROM COMPRA WHERE [Id Compra]=" + idCompra + "", cn);
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

        public void CargarCompra(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("SELECT [Id Compra], [Fecha de Compra], EXAMEN.[Id Examen], EXAMEN.Costo, PRODUCTO.[Id Producto], PRODUCTO.Nombre, PRODUCTO.Marca, PRODUCTO.Descripcion, PRODUCTO.Costo, Total FROM EXAMEN, PRODUCTO, COMPRA WHERE EXAMEN.[Id Examen] = COMPRA.[Id Examen] AND (PRODUCTO.[Id Producto] = COMPRA.[Id Producto])", cn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar la tabla de consultar: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LlenarTexBoxConsultaCompra(int idCompra, TextBox txtIdExamenCom, TextBox txtIdProductoCom, DateTimePicker dtpFechaCompra,
            TextBox txtTotal)
        {
            try
            {
                cmd = new SqlCommand("SELECT * FROM COMPRA WHERE [Id Compra]=" + idCompra + "", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtIdExamenCom.Text = dr["Id Examen"].ToString();
                    txtIdProductoCom.Text = dr["Id Producto"].ToString();
                    dtpFechaCompra.Text = dr["Fecha de Compra"].ToString();
                    txtTotal.Text = dr["Total"].ToString();
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar los campos: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string ActualizarCompra(int idCompra, int idExamen, int idProducto, string fechaCompra, float total)
        {
            string salida = "Se actualizaron los datos";
            MessageBox.Show(salida, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            try
            {
                cmd = new SqlCommand("UPDATE COMPRA SET [Id Compra] = " + idCompra + ", [Id Examen] = " + idExamen + ", [Id Producto] = " + idProducto + ", [Fecha de Compra] = '" + fechaCompra + "', Total = " + total + " WHERE [Id Compra] =" + idCompra + "", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se actualizo: " + ex.ToString();
                MessageBox.Show(salida, "Error de actualizar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return salida;
        }

        public DataTable BuscarCompra(int compra)
        {
            
            cmd = new SqlCommand(string.Format("SELECT [Id Compra], [Fecha de Compra], EXAMEN.[Id Examen], EXAMEN.Costo, PRODUCTO.[Id Producto], PRODUCTO.Nombre, PRODUCTO.Marca, PRODUCTO.Descripcion, PRODUCTO.Costo, Total FROM EXAMEN, PRODUCTO, COMPRA WHERE EXAMEN.[Id Examen] = COMPRA.[Id Examen] AND PRODUCTO.[Id Producto] = COMPRA.[Id Producto] AND [Id Compra] LIKE {0}", compra), cn);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "tabla");
            return ds.Tables["tabla"];
        }

        public bool EliminarCompra(string idCompra)
        {
            cmd = new SqlCommand(string.Format("DELETE FROM COMPRA WHERE [Id Compra]= {0}", idCompra), cn);
            //cmd = new SqlCommand("UPDATE PRODUCTO  SET Stock = Stock - Cantidad FROM PRODUCTO JOIN COMPRA ON COMPRA.[Id Compra] =" + idCompra +"",cn);
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
