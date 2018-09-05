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
    class Paciente
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

        public Paciente(string mensajeConexion)
        {
            mensajeConexion = obtenerString();
            cn = new SqlConnection(mensajeConexion);
            cn.Open();
        }

        //PACIENTE
        public string InsertarPaciente(int idPaciente, string nombrePaciente, string apellidoPaciente,
            string tipoPaciente, int edadPaciente, int telefonoPaciente, string direccionPaciente, string emailPaciente)
        {
            string salida = "Se insertó la información correctamente";
            MessageBox.Show(salida, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            try
            {
                cmd = new SqlCommand("INSERT INTO PACIENTE ([Id Paciente], Nombre, Apellido, [Tipo de Paciente], Edad, Telefono, Direccion, Email) VALUES(" + idPaciente + ", '" + nombrePaciente + "', '" + apellidoPaciente + "','" + tipoPaciente + "', " + edadPaciente + ", " + telefonoPaciente + ", '" + direccionPaciente + "', '" + emailPaciente + "')", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se conectó: " + ex.ToString();
                MessageBox.Show(salida, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return salida;
        }

        public int PacienteRegistrado(int idPaciente)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("SELECT * FROM PACIENTE WHERE [Id Paciente]=" + idPaciente + "", cn);
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

        public void CargarPaciente(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("SELECT * FROM PACIENTE WHERE ([Id Paciente] BETWEEN 1 AND 1000000)", cn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar la tabla de consultar: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LlenarTexBoxConsultaPaciente(int idPaciente, TextBox txtNombrePaciente, TextBox txtApellidoPaciente,
           TextBox txtTipoPaciente, ComboBox cbEdadPaciente, TextBox txtTelefonoPaciente, TextBox txtDireccionPaciente,
           TextBox txtEmailPaciente)
        {
            try
            {
                cmd = new SqlCommand("SELECT * FROM PACIENTE WHERE [Id Paciente]=" + idPaciente + "", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtNombrePaciente.Text = dr["Nombre"].ToString();
                    txtApellidoPaciente.Text = dr["Apellido"].ToString();
                    txtTipoPaciente.Text = dr["Tipo de Paciente"].ToString();
                    cbEdadPaciente.Text = dr["Edad"].ToString();
                    txtTelefonoPaciente.Text = dr["Telefono"].ToString();
                    txtDireccionPaciente.Text = dr["Direccion"].ToString();
                    txtEmailPaciente.Text = dr["Email"].ToString();
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar los campos: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string ActualizarPaciente(int idPaciente, string nombrePaciente, string apellidoPaciente,
            string tipoPaciente, int edadPaciente, int telefonoPaciente, string direccionPaciente, string emailPaciente)
        {
            string salida = "Se actualizaron los datos";
            MessageBox.Show(salida, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            try
            {
                cmd = new SqlCommand("UPDATE PACIENTE SET Nombre = '" + nombrePaciente + "', Apellido = '" + apellidoPaciente + "', [Tipo de Paciente] = '" + tipoPaciente + "', Edad = " + edadPaciente + ", Telefono = " + telefonoPaciente + ", Direccion = '" + direccionPaciente + "', Email = '" + emailPaciente + "' WHERE [Id Paciente] =" + idPaciente + "", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se actualizo: " + ex.ToString();
                MessageBox.Show(salida, "Error de actualizar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return salida;
        }

        public DataTable BuscarPaciente(string nombre)
        {
            cmd = new SqlCommand(string.Format("SELECT * FROM PACIENTE WHERE Nombre LIKE '%{0}%'", nombre), cn);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "tabla");
            return ds.Tables["tabla"];
        }

        public bool EliminarPaciente(string idPaciente)
        {
            cmd = new SqlCommand(string.Format("DELETE FROM PACIENTE WHERE [Id Paciente]= {0}", idPaciente), cn);
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
