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
        // Inicio de código de "Óscar Emilio Morales Lemus" con carné: "9959-23-3070" en la fecha de: "05/08/2026"
        public InicioDashboard()
        {
            InitializeComponent(); CargarKPIs();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        MySqlCommand objCmd;
        MySqlDataReader objDr;

        // Clase para cargar los KPIs del Dashboard en los labels - Oscar Morales 9959-23-3070
        private void CargarKPIs()
        {
            Cconexion objConexion = new Cconexion();
            MySqlConnection objMysqlConexion = objConexion.establecerConexion();

            try
            {
                objCmd = new MySqlCommand("DashboardDatos", objMysqlConexion);
                objCmd.CommandType = CommandType.StoredProcedure;

                objCmd.Parameters.Add("totalventas", MySqlDbType.Float).Direction = ParameterDirection.Output;
                objCmd.Parameters.Add("totalstock", MySqlDbType.Float).Direction = ParameterDirection.Output;
                objCmd.Parameters.Add("numclientes", MySqlDbType.Float).Direction = ParameterDirection.Output;
                objCmd.Parameters.Add("numusuarios", MySqlDbType.Float).Direction = ParameterDirection.Output;
                objCmd.Parameters.Add("numepleados", MySqlDbType.Float).Direction = ParameterDirection.Output;
                objCmd.Parameters.Add("numvideos", MySqlDbType.Float).Direction = ParameterDirection.Output;
                objCmd.Parameters.Add("numdevoluciones", MySqlDbType.Float).Direction = ParameterDirection.Output;

                objCmd.ExecuteNonQuery();

                lbl_totalVentas.Text = Convert.ToSingle(objCmd.Parameters["totalventas"].Value).ToString("N0");
                lbl_totalStock.Text = Convert.ToSingle(objCmd.Parameters["totalstock"].Value).ToString("N0");
                lbl_numClientes.Text = Convert.ToSingle(objCmd.Parameters["numclientes"].Value).ToString("N0");
                lbl_numUsuarios.Text = Convert.ToSingle(objCmd.Parameters["numusuarios"].Value).ToString("N0");
                lbl_numEmpleados.Text = Convert.ToSingle(objCmd.Parameters["numepleados"].Value).ToString("N0");
                lbl_numVideos.Text = Convert.ToSingle(objCmd.Parameters["numvideos"].Value).ToString("N0");
                lbl_numDevoluciones.Text = Convert.ToSingle(objCmd.Parameters["numdevoluciones"].Value).ToString("N0");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                objConexion.cerrarConexion();
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    // Fin de código de "Óscar Emilio Morales Lemus" con carné: "9959-23-3070" en la fecha de: "05/08/2026"
}
