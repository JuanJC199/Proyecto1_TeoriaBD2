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
    public partial class ModificarBD : Form
    {
        private MySqlConnection con;
        string query;
        public ModificarBD()
        {
            InitializeComponent();
        }

        public ModificarBD(MySqlConnection con)
        {
            InitializeComponent();
            this.con = con;
            LlenarCmb();
           
        }

        private void LlenarCmb()
        {
            try
            {
                cmbBD.Items.Clear();
                MySqlCommand cmd = new MySqlCommand("Show Databases", con);
                MySqlDataReader data = cmd.ExecuteReader();
                while (data.Read())
                {
                    cmbBD.Items.Add(data[0].ToString());
                }
                cmbBD.Items.Insert(0,"Elija BD");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                query = "RENAME DATABASE " + cmbBD.SelectedItem.ToString() + " to " + txtNombre.Text;
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = query;
                DialogResult r = MessageBox.Show(query, "DDL", MessageBoxButtons.OKCancel);
                if(r == DialogResult.OK)
                {
                    cmd.ExecuteNonQuery();
                    con.Close();
                    this.DialogResult = DialogResult.OK;
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
