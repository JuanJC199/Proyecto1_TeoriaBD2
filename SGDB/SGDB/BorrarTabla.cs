using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGDB
{
    public partial class BorrarTabla : Form
    {
        public MySqlConnection conn;
        public string query;
        public BorrarTabla()
        {
            InitializeComponent();
        }
        public BorrarTabla(MySqlConnection con)
        {
            InitializeComponent();
            conn = con;
            LlenarCmb();
        }

        private void LlenarCmb()
        {
            try
            {
                conn.Open();
                cmbBD.Items.Clear();
                MySqlCommand cmd = new MySqlCommand("Show Databases", conn);
                MySqlDataReader data = cmd.ExecuteReader();
                while (data.Read())
                {
                    cmbBD.Items.Add(data[0].ToString());
                }
                cmbBD.Items.Insert(0, "Elija BD");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //txtNombre.Clear();
            this.Hide();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            BorrarTable();
        }

        private void BorrarTable()
        {
            try
            {
                conn.Open();
                query = "DROP TABLE "+cmbBD.SelectedItem.ToString()+"."+cmbTable.SelectedItem.ToString();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = query;
                DialogResult r = MessageBox.Show(query, "DDL", MessageBoxButtons.OKCancel);
                if(r == DialogResult.OK)
                {
                    cmd.ExecuteNonQuery();
                    conn.Close();
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
            LlenarTables();
        }

        private void LlenarTables()
        {
            try
            {
                conn.Open();
                cmbTable.Items.Clear();
                MySqlCommand cmd = new MySqlCommand("Select table_name from information_schema.tables where Table_schema = '"+cmbBD.SelectedItem.ToString()+"';", conn);
                MySqlDataReader data = cmd.ExecuteReader();
                while (data.Read())
                {
                    cmbTable.Items.Add(data[0].ToString());
                }
                cmbTable.Items.Insert(0, "Elija tabla");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
