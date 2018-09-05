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
    class Asistente
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

        public Asistente (string mensajeConexion)
        {
            mensajeConexion = obtenerString();
            cn = new SqlConnection(mensajeConexion);
            cn.Open();
        }

        //ASISTENTE
        public string InsertarAsistente(int idAsistente, string nombreAsistente, string apellidoAsistente, 
            string tipoAsitente, int edadAsistente, string direccionAsistente, int telefonoAsistente, string emailAsistente, 
            string accesoAsistente, string usuarioAsistente, string contrasenaAsistente)
        {
            string salida = "Se insertó la información correctamente";
            MessageBox.Show(salida, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            try
            {
                cmd = new SqlCommand("INSERT INTO ASISTENTE ([Id Asistente], Nombre, Apellido, [Tipo de Asistente], Edad, Telefono, Direccion, Email, Acceso, Usuario, Contrasena) VALUES(" + idAsistente + ", '" + nombreAsistente + "', '" + apellidoAsistente + "','"+ tipoAsitente +"', " + edadAsistente + ", " + telefonoAsistente + ",'"+ direccionAsistente +"', '" + emailAsistente + "', '" + accesoAsistente + "', '" + usuarioAsistente + "', '" + contrasenaAsistente + "')", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se conectó: " + ex.ToString();
                MessageBox.Show(salida, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return salida;
        }

        public int AsistenteRegistrado(int idAsistente)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("SELECT * FROM ASISTENTE WHERE [Id Asistente]=" + idAsistente + "", cn);
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

        public void CargarAsistentes(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("SELECT * FROM ASISTENTE", cn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar la tabla de consultar: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CargarUsuarioAsistente(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("SELECT [Id Asistente], Acceso, Usuario, Contrasena FROM ASISTENTE", cn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar la tabla de consultar: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LlenarTexBoxConsultaAsistente(int idAsistente, TextBox txtNombreAsistente, TextBox txtApellidoAsistente,
            TextBox txtTipoAsitente, ComboBox cbEdadAsistente, TextBox txtDireccionAsistente,  TextBox txtTelefonoAsistente,
            TextBox txtEmailAsistente, TextBox txtAccesoAsistente, TextBox txtUsuarioAsistente, TextBox txtContrasenaAsistente)
        {
            try
            {
                cmd = new SqlCommand("SELECT * FROM ASISTENTE WHERE [Id Asistente]=" + idAsistente + "", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtNombreAsistente.Text = dr["Nombre"].ToString();
                    txtApellidoAsistente.Text = dr["Apellido"].ToString();
                    txtTipoAsitente.Text = dr["Tipo de Asistente"].ToString();
                    cbEdadAsistente.Text = dr["Edad"].ToString();
                    txtDireccionAsistente.Text = dr["Direccion"].ToString();
                    txtTelefonoAsistente.Text = dr["Telefono"].ToString();
                    txtEmailAsistente.Text = dr["Email"].ToString();
                    txtAccesoAsistente.Text = dr["Acceso"].ToString();
                    txtUsuarioAsistente.Text = dr["Usuario"].ToString();
                    txtContrasenaAsistente.Text = dr["Contrasena"].ToString();
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar los campos: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string ActualizarAsistente(int idAsistente, string nombreAsistente, string apellidoAsistente,
            string tipoAsitente, int edadAsistente, string direccionAsistente, int telefonoAsistente, string emailAsistente,
            string accesoAsistente, string usuarioAsistente, string contrasenaAsistente)
        {
            string salida = "Se actualizaron los datos";
            MessageBox.Show(salida, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            try
            {
                cmd = new SqlCommand("UPDATE ASISTENTE SET Nombre = '" + nombreAsistente + "', Apellido = '" + apellidoAsistente + "', [Tipo de Asistente] = '" + tipoAsitente +"', Edad = " + edadAsistente + ", Telefono = " + telefonoAsistente + ", Direccion = '" + direccionAsistente + "', Email = '" + emailAsistente + "', Acceso = '" + accesoAsistente + "', Usuario = '" + usuarioAsistente + "', Contrasena = '" + contrasenaAsistente + "'  WHERE [Id Asistente] =" + idAsistente + "", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se actualizo: " + ex.ToString();
                MessageBox.Show(salida, "Error de actualizar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return salida;
        }

        public DataTable BuscarAsistente(string nombre)
        {
            cmd = new SqlCommand(string.Format("SELECT * FROM ASISTENTE WHERE Nombre LIKE '%{0}%'", nombre), cn);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "tabla");
            return ds.Tables["tabla"];
        }

        public bool EliminarAsistente(string idAsistente)
        {
            cmd = new SqlCommand(string.Format("DELETE FROM ASISTENTE WHERE [Id Asistente]= {0}", idAsistente), cn);
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

        public bool logear(string usuario, string contrasena)
        {
            cmd = new SqlCommand("SELECT Acceso, Usuario, Contrasena FROM ASISTENTE WHERE Usuario = @usuario AND Contrasena = @contrasena", cn);
            cmd.Parameters.AddWithValue("usuario", usuario);
            cmd.Parameters.AddWithValue("contrasena", contrasena);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count == 1)
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