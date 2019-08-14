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
    public partial class CrearView : Form
    {
        private MySqlConnection con;
        private string query;
        private string name;
        private string var;
        public CrearView()
        {
            InitializeComponent();
        }

        public CrearView(MySqlConnection con)
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

        private void BtCerrar_Click(object sender, EventArgs e)
        {
            CrearV();
        }

        private void CrearV()
        {
            try
            {
                con.Open();
                query = name;
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
            LlenarTable();
           // EditarText();
        }

        private void EditarText()
        {
            name = "";
            name = "CREATE VIEW "+cmbBD.SelectedItem.ToString()+"."+var+"AS Select * From  "+cmbBD.SelectedItem.ToString()+"."+cmbTable.SelectedItem.ToString()+";";
            rtText.Text = name;
        }

        private void LlenarTable()
        {

            try
            {
                con.Open();
                cmbTable.Items.Clear();
                MySqlCommand cmd = new MySqlCommand("Select table_name from information_schema.tables where Table_schema = '" + cmbBD.SelectedItem.ToString() + "';", con);
                MySqlDataReader data = cmd.ExecuteReader();
                while (data.Read())
                {
                    cmbTable.Items.Add(data[0].ToString());
                }
                cmbTable.Items.Insert(0, "Elija tabla");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CmbTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            EditarText();
        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {
            var = txtNombre.Text;
            EditarText();
        }
    }
}
