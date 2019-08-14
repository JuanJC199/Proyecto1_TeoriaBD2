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
    public partial class BorrarText : Form
    {
        private MySqlConnection con;
        private string v;
        private string querylist;
        private string query;
        private string nombre;

        public BorrarText()
        {
            InitializeComponent();
        }

        public BorrarText(MySqlConnection con, string v)
        {
            InitializeComponent();
            this.con = con;
            this.v = v;
           // LlenarCmb();
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
            BorrarT();
        }

        private void BorrarT()
        {
            con.Open();
            //query = "CREATE INDEX " + txtNombre.Text + " ON " + cmbBD.SelectedItem.ToString() + "." + cmbTable.SelectedItem.ToString() + "(" + cmbCampo.SelectedItem.ToString() + ");";
            MySqlCommand cmd = con.CreateCommand();
            query = rtText.Text;
            cmd.CommandText = query;
            DialogResult r = MessageBox.Show(query, "DDL", MessageBoxButtons.OKCancel);
            if (r == DialogResult.OK)
            {
                cmd.ExecuteNonQuery();
                con.Close();
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                con.Close();
            }
        }

        private void BtCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void CmbBD_SelectedIndexChanged(object sender, EventArgs e)
        {
        
                LlenarNombre();
            
        }

        private void LlenarNombre()
        {
            try
            {
                if (cmbProceso.SelectedItem.ToString().Equals("Procedure"))
                {
                    querylist = "Show procedure status where Db = '" + cmbBD.SelectedItem.ToString() + "';";
                }
                else if (cmbProceso.SelectedItem.ToString().Equals("Function"))
                {
                    querylist = "SHOW FUNCTION STATUS where Db = '" + cmbBD.SelectedItem.ToString() + "';";
                }
                else if (cmbProceso.SelectedItem.ToString().Equals("Trigger"))
                {
                    querylist = "select trigger_schema, trigger_name, action_statement from information_schema.triggers where trigger_schema = '"+cmbBD.SelectedItem.ToString()+"'; ";
                }
                con.Open();
                cmbNombre.Items.Clear();
                MySqlCommand cmd = new MySqlCommand(querylist, con);
                MySqlDataReader data = cmd.ExecuteReader();
                while (data.Read())
                {
                    cmbNombre.Items.Add(data[1].ToString());
                }
                cmbNombre.Items.Insert(0, "Elija Nombre");
                con.Close();


            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void CmbProceso_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarCmb();
            
        }

        private void CmbNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProceso.SelectedItem.ToString().Equals("Procedure"))
            {
                rtText.Text = "DROP PROCEDURE `" + cmbBD.SelectedItem.ToString() + "`.`" + cmbNombre.SelectedItem.ToString() + "`;";
            }
            else if (cmbProceso.SelectedItem.ToString().Equals("Function"))
            {
                rtText.Text = "DROP FUNCTION `" + cmbBD.SelectedItem.ToString() + "`.`" + cmbNombre.SelectedItem.ToString() + "`;";
            }
            else if (cmbProceso.SelectedItem.ToString().Equals("Trigger"))
            {
                rtText.Text = "DROP TRIGGER `" + cmbBD.SelectedItem.ToString() + "`.`" + cmbNombre.SelectedItem.ToString() + "`;";
            }
        }
    }
}
