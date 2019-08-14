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
    public partial class CrearBD : Form
    {
        private MySqlConnection conn;

        public CrearBD()
        {
            InitializeComponent();
        }

        public CrearBD(MySqlConnection con)
        {
            InitializeComponent();
            conn = con;
           
            txtNombre.Clear();

        }

        private void BtCrear_Click(object sender, EventArgs e)
        {
            //DialogResult.OK;
            try
            {
                conn.Open();
                string query = "CREATE SCHEMA " + txtNombre.Text;
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = query;
                DialogResult r = MessageBox.Show(query, "DDL", MessageBoxButtons.OKCancel);
                if (r == DialogResult.OK)
                {
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    this.Hide();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void BtCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
