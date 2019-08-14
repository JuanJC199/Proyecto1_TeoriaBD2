using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SGDB
{
    public partial class Form1 : Form
    {
        public string conexion;
        public string pass;
        public string data;
        public string cadenaconexion;
        public MySqlConnection conexiondb;
        public Form1()
        {
            InitializeComponent();
        }

        private void Btconectar_Click(object sender, EventArgs e)
        {
            conexion = txtconexion.Text;
            pass = txtpass.Text;
            data = "";
            cadenaconexion = "server= localhost; port=3306; user id=" + conexion + "; password=" + pass +  "; database = mysql";
            conexiondb = new MySqlConnection(cadenaconexion);
            try
            {
                conexiondb.Open();
                MySqlDataReader reader = null;
                MySqlCommand cmd = new MySqlCommand("SHOW DATABASES", conexiondb);
                conexiondb.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            Principal pri = new Principal(conexiondb);
            this.Hide();
            pri.Show();
        }

        private void Btcancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
