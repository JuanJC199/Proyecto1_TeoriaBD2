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
    public partial class BorrarView : Form
    {
        private MySqlConnection con;
        private string query;
        public BorrarView()
        {
            InitializeComponent();
        }

        public BorrarView(MySqlConnection con)
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
                cmbBD.Items.Clear();
                MySqlCommand cmd = new MySqlCommand("Show Databases", con);
                MySqlDataReader data = cmd.ExecuteReader();
                while (data.Read())
                {
                    cmbBD.Items.Add(data[0].ToString());
                }
                cmbBD.Items.Insert(0, "Elija BD");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtBorrar_Click(object sender, EventArgs e)
        {
            BorrarV();
        }

        private void BorrarV()
        {
            try
            {
                con.Open();
                query = "DROP VIEW "+cmbBD.SelectedItem.ToString()+"."+cmbNombre.SelectedItem.ToString()+" ;";
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = query;
                DialogResult r = MessageBox.Show(query, "DDL", MessageBoxButtons.OKCancel);
                if (r == DialogResult.OK)
                {
                    cmd.ExecuteNonQuery();
                    con.Close();
                    this.DialogResult = DialogResult.OK;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CmbBD_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarName();
        }

        private void LlenarName()
        {
            try
            {
                con.Open();
                cmbNombre.Items.Clear();
                MySqlCommand cmd = new MySqlCommand("SHOW FULL TABLES IN "+cmbBD.SelectedItem.ToString()+" where TABLE_TYPE LIKE 'VIEW';", con);
                MySqlDataReader data = cmd.ExecuteReader();
                while (data.Read())
                {
                    cmbNombre.Items.Add(data[0].ToString());
                }
                cmbNombre.Items.Insert(0, "Elija BD");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
