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
    public partial class MostrarForm : Form
    {
        private MySqlConnection con;
        private string v;
        private string commando;
        private string table;
        public MostrarForm()
        {
            InitializeComponent();
        }

        public MostrarForm(MySqlConnection con, string v)
        {
            InitializeComponent();
            this.con = con;
            this.v = v;
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

        private void BtOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void CmbBD_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarTables();
        }

        private void LlenarTables()
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
                table = cmbTable.Items[1].ToString();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CmbTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            table = cmbTable.SelectedItem.ToString();
            LlenarRes();
        }

        private void LlenarRes()
        {
            con.Open();
            cmbName.Items.Clear();
            switch (v)
            {
                case "Tablas":
                    commando = "Select table_name from information_schema.tables where Table_schema = '" + cmbBD.SelectedItem.ToString() + "';";
                    break;
                case "Indices":
                    commando = "Show index from " + cmbBD.SelectedItem.ToString() + "." + table + ";";
                    break;
                case "Procedimientos":
                    CambiarText("Show procedure status where Db = '" + cmbBD.SelectedItem.ToString() + "';");
                    
                    break;
                case "Functions":
                    CambiarText( "SHOW FUNCTION STATUS where Db = '" + cmbBD.SelectedItem.ToString() + "';");
                    ;
                    break;
                case "Triggers":
                    CambiarText("select trigger_schema, trigger_name, action_statement from information_schema.triggers where trigger_schema = '" + cmbBD.SelectedItem.ToString() + "'; ");                   
                    break;
                case "Checks":
                    commando = "Show index from " + cmbBD.SelectedItem.ToString() + "." + table + ";";
                    break;
                case "Views":
                    commando = "SHOW FULL TABLES IN " + cmbBD.SelectedItem.ToString() + " where TABLE_TYPE LIKE 'VIEW';";
                    break;
            }
            MySqlCommand cmd = new MySqlCommand(commando, con);
            MySqlDataReader data = cmd.ExecuteReader();
            while (data.Read())
            {
                cmbName.Items.Add(data[0].ToString());
            }
            cmbName.Items.Insert(0, "Resultado");
            con.Close();

        }

        private void CambiarText(string v)
        {
            con.Open();
            cmbName.Items.Clear();
            MySqlCommand cmd = new MySqlCommand(v, con);
            MySqlDataReader data = cmd.ExecuteReader();
            while (data.Read())
            {
                cmbName.Items.Add(data[1].ToString());
            }
            cmbName.Items.Insert(0, "Resultado");
            con.Close();
        }
    }
}
