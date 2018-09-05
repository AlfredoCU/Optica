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
    class Conexion
    {
        SqlConnection cn;

        public static string obtenerString()
        {
            return Settings.Default.Setting;
        }

        public Conexion()
        {
            try
            {
                cn = new SqlConnection(obtenerString());
                cn.Open();
                MessageBox.Show("Está contactado a la base de datos ", "Conexión", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se conectó a la base de datos " + ex.ToString(), "No hay conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}