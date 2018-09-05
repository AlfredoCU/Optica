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

namespace Optica
{
    class Doctor
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

        public Doctor(string mensajeConexion)
        {
            mensajeConexion = obtenerString();
            cn = new SqlConnection(mensajeConexion);
            cn.Open();
        }

        //DOCTOR.
        public string InsertarDoctor(int idDoctor, string nombreDoctor, string apellidoDoctor, int edadDoctor,
            string direccionDoctor, int telefonoDoctor, int matricula, string especialidad, string emailDoctor,
            string accesoDoctor, string usuarioDoctor, string contrasenaDoctor)
        {
            string salida = "Se insertó la información correctamente";
            MessageBox.Show(salida, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            try
            { //Tratamiento de SQL
                cmd = new SqlCommand("INSERT INTO DOCTOR ([Id Doctor], Nombre, Apellido, Edad, Direccion, Telefono, Matricula, Especialidad, Email, Acceso, Usuario, Contrasena) VALUES(" + idDoctor + ", '" + nombreDoctor + "', '" + apellidoDoctor + "', " + edadDoctor + ", '" + direccionDoctor + "', " + telefonoDoctor + ", " + matricula + ", '" + especialidad + "', '" + emailDoctor + "', '" + accesoDoctor + "', '" + usuarioDoctor + "', '" + contrasenaDoctor + "')", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se conectó: " + ex.ToString();
                MessageBox.Show(salida, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return salida;
        }

        public int DoctorRegistrado(int idDoctor)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("SELECT * FROM DOCTOR WHERE [Id Doctor]=" + idDoctor + "", cn);
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

        public void CargarDoctores(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("SELECT * FROM DOCTOR WHERE ([Id Doctor] BETWEEN 1 AND 1000000)", cn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar la tabla de consultar: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CargarDoctoresVer(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("SELECT [Id Doctor], Nombre, Apellido, Edad, Matricula, Especialidad FROM DOCTOR WHERE ([Id Doctor] BETWEEN 1 AND 1000000)", cn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar la tabla de consultar: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CargarUsuarioDoctor(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("SELECT [Id Doctor], Acceso, Usuario, Contrasena FROM DOCTOR WHERE ([Id Doctor] BETWEEN 1 AND 1000000)", cn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar la tabla de consultar: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LlenarTexBoxConsultaDoctor(int idDoctor, TextBox txtNombreDoctor, TextBox txtApellidoDoctor,
            ComboBox cbEdadDoctor, TextBox txtDireccionDoctor, TextBox txtTelefonoDoctor, TextBox txtMatriculaDoctor,
            TextBox txtEspecialidadDoctor, TextBox txtEmailDoctor, TextBox txtAccesoDoctor, TextBox txtUsuarioDoctor, 
            TextBox txtContrasenaDoctor)
        {
            try
            {
                cmd = new SqlCommand("SELECT * FROM DOCTOR WHERE [Id Doctor]=" + idDoctor + "", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtNombreDoctor.Text = dr["Nombre"].ToString();
                    txtApellidoDoctor.Text = dr["Apellido"].ToString();
                    cbEdadDoctor.Text = dr["Edad"].ToString();
                    txtDireccionDoctor.Text = dr["Direccion"].ToString();
                    txtTelefonoDoctor.Text = dr["Telefono"].ToString();
                    txtMatriculaDoctor.Text = dr["Matricula"].ToString();
                    txtEspecialidadDoctor.Text = dr["Especialidad"].ToString();
                    txtEmailDoctor.Text = dr["Email"].ToString();
                    txtAccesoDoctor.Text = dr["Acceso"].ToString();
                    txtUsuarioDoctor.Text = dr["Usuario"].ToString();
                    txtContrasenaDoctor.Text = dr["Contrasena"].ToString();
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar los campos: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string ActualizarDoctor(int idDoctor, string nombreDoctor, string apellidoDoctor, int edadDoctor,
            string direccionDoctor, int telefonoDoctor, int matricula, string especialidad, string emailDoctor,
            string accesoDoctor, string usuarioDoctor, string contrasenaDoctor)
        {
            string salida = "Se actualizaron los datos";
            MessageBox.Show(salida, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            try
            {
                cmd = new SqlCommand("UPDATE DOCTOR SET Nombre = '" + nombreDoctor + "', Apellido = '" + apellidoDoctor + "', Edad = " + edadDoctor + ", Direccion = '" + direccionDoctor + "', Telefono = " + telefonoDoctor + ", Matricula = " + matricula + ", Especialidad = '" + especialidad + "', Email = '" + emailDoctor + "', Acceso = '" + accesoDoctor + "', Usuario = '" + usuarioDoctor + "', Contrasena = '" + contrasenaDoctor + "'  WHERE [Id Doctor] =" + idDoctor + "", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se actualizo: " + ex.ToString();
                MessageBox.Show(salida, "Error de actualizar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return salida;
        }

        public DataTable BuscarDoctor(string nombre)
        {
            cmd = new SqlCommand(string.Format("SELECT * FROM DOCTOR WHERE Nombre LIKE '%{0}%'", nombre), cn);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "tabla");
            return ds.Tables["tabla"];
        }

        public bool EliminarDoctor(string idDoctor)
        {
            cmd = new SqlCommand(string.Format("DELETE FROM DOCTOR WHERE [Id Doctor]= {0}", idDoctor), cn);
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
            cmd = new SqlCommand("SELECT Acceso, Usuario, Contrasena FROM DOCTOR WHERE Usuario = @usuario AND Contrasena = @contrasena",cn);
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