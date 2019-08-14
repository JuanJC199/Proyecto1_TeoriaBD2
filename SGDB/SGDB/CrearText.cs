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
    public partial class CrearText : Form
    {
        private MySqlConnection con;
        private string v;
        private string texto;
        private string query;
        private string bdname;
        private string nombre;
        public CrearText()
        {
            InitializeComponent();
        }

        public CrearText(MySqlConnection con, string v)
        {
            InitializeComponent();
            this.con = con;
            this.v = v;
            LlenarCmb();
            LlenarText();
        }

        private void LlenarText()
        {
            if (v.Equals("Procedure"))
            {
                texto = "";
                texto = "CREATE PROCEDURE  "+bdname+".`"+nombre+"` () \n BEGIN \n  END";
                rtText.Text = texto;

            }
            else if (v.Equals("Function"))
            {
                texto = "";
                texto = "CREATE FUNCTION "+bdname+ ".`"+nombre+"` () \nRETURNS INTEGER \nREADS SQL DATA DETERMINISTIC \n BEGIN \nRETURN 1; \n END";
                rtText.Text = texto;
            }
            else if (v.Equals("Trigger"))
            {
                texto = "";
                texto = "CREATE DEFINER = CURRENT_USER TRIGGER `"+bdname+"`.`"+nombre+"` BEFORE/AFTER INSERT/UPDATE/DELETE ON `` FOR EACH ROW \nBEGIN \nEND";
                rtText.Text = texto;
            }
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

        private void BtCrear_Click(object sender, EventArgs e)
        {
            CrearTabla();
        }

        private void CrearTabla()
        {
            try
            {
                con.Open();
                //query = "CREATE INDEX " + txtNombre.Text + " ON " + cmbBD.SelectedItem.ToString() + "." + cmbTable.SelectedItem.ToString() + "(" + cmbCampo.SelectedItem.ToString() + ");";
                MySqlCommand cmd = con.CreateCommand();
                if (v.Equals("Procedure"))
                {
                    texto = rtText.Text;
                    query =  texto ;
                }
                else if (v.Equals("Function"))
                {
                    texto = rtText.Text;
                    query = texto;
                }
                else if (v.Equals("Trigger"))
                {
                    texto = rtText.Text;
                    query = texto;

                }
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void BtCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void CmbBD_SelectedIndexChanged(object sender, EventArgs e)
        {
            CambiarBD();
            LlenarText();
        }

        private void CambiarBD()
        {
            bdname = "";
            bdname = cmbBD.SelectedItem.ToString();
        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {
            nombre = txtNombre.Text;
            LlenarText();
        }
    }
}
