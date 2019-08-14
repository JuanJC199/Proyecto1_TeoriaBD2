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
    public partial class BorrarIndice : Form
    {
        private MySqlConnection con;
        public string query;
        public BorrarIndice()
        {
            InitializeComponent();
        }

        public BorrarIndice(MySqlConnection con)
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
            try
            {
                con.Open();
                query = "ALTER TABLE "+cmbBD.SelectedItem.ToString()+"."+cmbTable.SelectedItem.ToString()+" DROP INDEX "+ cmbIndex.SelectedItem.ToString();
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
            LlenarTabla();
        }

        private void LlenarTabla()
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
            LlenarIndex();   
        }

        private void LlenarCampo()
        {
            /*
            try
            {
                con.Open();
                cmbCampo.Items.Clear();
                string table = cmbTable.SelectedItem.ToString();
                MySqlCommand cmd = new MySqlCommand("select COLUMN_NAME from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME = '" + table + "';", con); //+ +
                MySqlDataReader data = cmd.ExecuteReader();
                while (data.Read())
                {
                    cmbCampo.Items.Add(data[0].ToString());
                }
                cmbCampo.Items.Insert(0, "Elija campo");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            */
        }

        private void LlenarIndex()
        {
            try
            {
                con.Open();
                cmbIndex.Items.Clear();
                string table = cmbTable.SelectedItem.ToString();
                MySqlCommand cmd = new MySqlCommand("Show index from "+cmbBD.SelectedItem.ToString()+"."+table+"; ", con); //+ +
                MySqlDataReader data = cmd.ExecuteReader();
                while (data.Read())
                {
                    cmbIndex.Items.Add(data[2].ToString());
                }
                cmbIndex.Items.Insert(0, "Elija indice");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarIndex();
        }
    }
}
