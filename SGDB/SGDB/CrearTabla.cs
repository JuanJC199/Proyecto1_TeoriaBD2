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
    public partial class CrearTabla : Form
    {
        public string query;
        public string columnas = "";
        public string columnasrect;
        public string varchar;
        MySqlConnection connection;
        public CrearTabla(MySql.Data.MySqlClient.MySqlConnection con)
        {
            InitializeComponent();
            connection = con;
            LlenarCmb();
        }

        private void LlenarCmb()
        {
            
            try
            {            
                connection.Open();
                cmbBD.Items.Clear();
                MySqlCommand cmd = new MySqlCommand("Show Databases", connection);
                MySqlDataReader data = cmd.ExecuteReader();
                while (data.Read())
                {
                    cmbBD.Items.Add(data[0].ToString());
                }
                cmbBD.Items.Insert(0, "Elija BD");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            dvTabla.Rows.Remove(dvTabla.CurrentRow);
        }

        private void BtCrear_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                columnas = "";
                MySqlCommand cmd = connection.CreateCommand();
                foreach (DataGridViewRow row in dvTabla.Rows)
                {
                    if (columnas.Equals(""))
                    {
                        columnas += row.Cells["Atributo"].Value + " " + row.Cells["Campo"].Value + " " + row.Cells["Null"].Value;
                    }
                    else {
                        columnas += ", " + row.Cells["Atributo"].Value + " " + row.Cells["Campo"].Value + " " + row.Cells["Null"].Value;
                    }

                }
                //columnas = columnas.Remove((columnas.Length - 1));
                columnasrect = "";
                columnasrect = columnas.Remove((columnas.Length - 4));
                query = "CREATE TABLE " + cmbBD.SelectedItem.ToString() + "." + txtNombre.Text + "(" + columnasrect + ")";
                cmd.CommandText = query;
                DialogResult r = MessageBox.Show(query, "DDL", MessageBoxButtons.OKCancel);
                if (r == DialogResult.OK)
                {
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    this.DialogResult = DialogResult.OK;
                    
                }
                else
                {
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                connection.Close();
                MessageBox.Show(ex.Message);
            }
            
        }

        private void Creartabla(string quer)
        {
            
        }

        private void BtAdd_Click(object sender, EventArgs e)
        {
            varchar = "";
            varchar = cmbCampo.SelectedItem.ToString();
            if (cmbCampo.SelectedItem.ToString().Equals("Varchar"))
            {
                using (VarCan vc = new VarCan())
                {
                    if (vc.ShowDialog() == DialogResult.OK)
                    {
                        varchar += "(" + vc.numero + ")";
                    }
                }
                
            }
            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dvTabla);
            fila.Cells[0].Value = txtAtributo.Text;
            fila.Cells[1].Value = varchar;
            fila.Cells[2].Value = cmbKey.SelectedItem.ToString();
            dvTabla.Rows.Add(fila);
        }
    }
}
