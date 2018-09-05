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
    class Examen
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

        public Examen(string mensajeConexion)
        {
            mensajeConexion = obtenerString();
            cn = new SqlConnection(mensajeConexion);
            cn.Open();
        }

        public string InsertarExamen(int idPacienteExa, int idDoctoExa, int idExamen, string observaciones, 
            string fechaExamen, float costo)
        {
            string salida = "Se insertó la información correctamente";
            MessageBox.Show(salida, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            try
            {
                cmd = new SqlCommand("INSERT INTO EXAMEN ([Id Paciente], [Id Doctor], [Id Examen], Observaciones, [Fecha de Examen], Costo) VALUES(" + idPacienteExa + ", " + idDoctoExa +", " + idExamen + ", '" + observaciones + "', '" + fechaExamen + "', " + costo + ")", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se conectó: " + ex.ToString();
                MessageBox.Show(salida, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return salida;
        }

        public int ExamenRegistrado(int idExamen)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("SELECT * FROM EXAMEN WHERE [Id Examen]=" + idExamen + "", cn);
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

        public void CargarExamen(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("SELECT EXAMEN.[Id Paciente], PACIENTE.Nombre, PACIENTE.Apellido, EXAMEN.[Id Doctor], DOCTOR.Nombre, DOCTOR.Apellido, DOCTOR.Matricula, EXAMEN.[Id Examen], EXAMEN.[Fecha de Examen], EXAMEN.Observaciones, EXAMEN.Costo FROM PACIENTE, DOCTOR, EXAMEN WHERE PACIENTE.[Id Paciente] = EXAMEN.[Id Paciente] AND DOCTOR.[Id Doctor] = EXAMEN.[Id Doctor]", cn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar la tabla de consultar: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CargarPacienteDoctorExamen(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("SELECT EXAMEN.[Id Paciente], PACIENTE.Nombre, PACIENTE.Apellido, EXAMEN.[Id Doctor], DOCTOR.Nombre, DOCTOR.Apellido, DOCTOR.Matricula, EXAMEN.[Id Examen], EXAMEN.[Fecha de Examen], EXAMEN.Observaciones, EXAMEN.Costo FROM PACIENTE, DOCTOR, EXAMEN WHERE PACIENTE.[Id Paciente] = EXAMEN.[Id Paciente] AND DOCTOR.[Id Doctor] = EXAMEN.[Id Doctor] AND ([Id Examen] BETWEEN 1 AND 1000000)", cn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar la tabla de consultar: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LlenarTexBoxConsultaExamen(TextBox txtIdPacienteExa, TextBox txtIdDoctorExa, int idExamen,
            RichTextBox rtbObservaciones, DateTimePicker dtpFechaExamen, TextBox txtCostoExamen)
        {
            try
            {
                cmd = new SqlCommand("SELECT * FROM EXAMEN WHERE [Id Examen]=" + idExamen + "", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtIdPacienteExa.Text = dr["Id Paciente"].ToString();
                    txtIdDoctorExa.Text = dr["Id Doctor"].ToString();
                    rtbObservaciones.Text = dr["Observaciones"].ToString();
                    dtpFechaExamen.Text = dr["Fecha de Examen"].ToString();
                    txtCostoExamen.Text = dr["Costo"].ToString();
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar los campos: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string ActualizarExamen(int idPacienteExa, int idDoctoExa, int idExamen, string observaciones,
            string fechaExamen, float costo)
        {
            string salida = "Se actualizaron los datos";
            MessageBox.Show(salida, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            try
            {
                cmd = new SqlCommand("UPDATE EXAMEN SET [Id Paciente] = " + idPacienteExa + ", [Id Doctor] = " + idDoctoExa + ", Observaciones = '" + observaciones + "', [Fecha de Examen] = '" + fechaExamen + "', Costo = " + costo + " WHERE [Id Examen] =" + idExamen + "", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se actualizo: " + ex.ToString();
                MessageBox.Show(salida, "Error de actualizar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return salida;
        }

        public DataTable BuscarExamen(string nombre)
        {
            cmd = new SqlCommand(string.Format("SELECT EXAMEN.[Id Paciente], PACIENTE.Nombre, PACIENTE.Apellido, EXAMEN.[Id Doctor], DOCTOR.Nombre, DOCTOR.Apellido, DOCTOR.Matricula, EXAMEN.[Id Examen], EXAMEN.[Fecha de Examen], EXAMEN.Observaciones, EXAMEN.Costo FROM PACIENTE, DOCTOR, EXAMEN WHERE PACIENTE.[Id Paciente] = EXAMEN.[Id Paciente] AND DOCTOR.[Id Doctor] = EXAMEN.[Id Doctor] AND PACIENTE.Nombre LIKE '%{0}%'", nombre), cn);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "tabla");
            return ds.Tables["tabla"];
        }

        public bool EliminarExamen(string idExamen)
        {
            cmd = new SqlCommand(string.Format("DELETE FROM EXAMEN WHERE [Id Examen]= {0}", idExamen), cn);
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