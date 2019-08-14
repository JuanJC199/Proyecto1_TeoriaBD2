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
    public partial class BorrarBD : Form
    {
        private MySqlConnection con;
        public string query;
        public BorrarBD()
        {
            InitializeComponent();
        }

        public BorrarBD(MySqlConnection con)
        {
            InitializeComponent();
            this.con = con;
        }

        private void BtBorrar_Click(object sender, EventArgs e)
        {
            try {
                con.Open();
                string query = "DROP SCHEMA " + txtNombre.Text;
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = query;
                DialogResult r = MessageBox.Show( query, "DDL", MessageBoxButtons.OKCancel);
                if (r == DialogResult.OK)
                {
                    cmd.ExecuteNonQuery();
                    con.Close();
                    this.DialogResult = DialogResult.OK;
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
