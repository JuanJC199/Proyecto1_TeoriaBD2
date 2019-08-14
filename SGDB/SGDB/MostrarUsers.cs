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
    public partial class MostrarUsers : Form
    {
        private MySqlConnection con;

        public MostrarUsers()
        {
            InitializeComponent();
        }

        public MostrarUsers(MySqlConnection con)
        {
            InitializeComponent();
            this.con = con;
            LlenarCmb();
        }

        private void LlenarCmb()
        {
            try
            {
                con.Open();
                cmbName.Items.Clear();
                MySqlCommand cmd = new MySqlCommand("Select User from mysql.user;", con);
                MySqlDataReader data = cmd.ExecuteReader();
                while (data.Read())
                {
                    cmbName.Items.Add(data[0].ToString());
                }
                cmbName.Items.Insert(0, "Users");
//                table = cmbTable.Items[1].ToString();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
