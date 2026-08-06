using MySqlConnector;
using Renta_de_Video_2._0.Clases;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Renta_de_Video_2._0
{
    public partial class InicioDashboard : Form
    {
        public InicioDashboard()
        {
            InitializeComponent(); CargarKPIs();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        MySqlCommand cmd;
        MySqlDataReader dr;

        // Clase para cargar los KPIs del Dashboard en los labels - Oscar Morales 9959-23-3070
        private void CargarKPIs()
        {
            Cconexion c = new Cconexion();
            MySqlConnection conexion = c.establecerConexion();

            try
            {
                cmd = new MySqlCommand("DashboardDatos", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("totalventas", MySqlDbType.Float).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("totalstock", MySqlDbType.Float).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("numclientes", MySqlDbType.Float).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("numusuarios", MySqlDbType.Float).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("numepleados", MySqlDbType.Float).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("numvideos", MySqlDbType.Float).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("numdevoluciones", MySqlDbType.Float).Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();

                lbl_totalventas.Text = Convert.ToSingle(cmd.Parameters["totalventas"].Value).ToString("N0");
                lbl_totalstock.Text = Convert.ToSingle(cmd.Parameters["totalstock"].Value).ToString("N0");
                lbl_numclientes.Text = Convert.ToSingle(cmd.Parameters["numclientes"].Value).ToString("N0");
                lbl_numusuarios.Text = Convert.ToSingle(cmd.Parameters["numusuarios"].Value).ToString("N0");
                lbl_numepleados.Text = Convert.ToSingle(cmd.Parameters["numepleados"].Value).ToString("N0");
                lbl_numvideos.Text = Convert.ToSingle(cmd.Parameters["numvideos"].Value).ToString("N0");
                lbl_numdevoluciones.Text = Convert.ToSingle(cmd.Parameters["numdevoluciones"].Value).ToString("N0");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                c.cerrarConexion();
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
