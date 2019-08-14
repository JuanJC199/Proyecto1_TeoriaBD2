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
    public partial class Principal : Form
    {
        public MySqlConnection con;
        public Principal()
        {
            InitializeComponent();
        }

        public Principal(MySqlConnection conn)
        {
            InitializeComponent();
            con = conn;
            trBD.Nodes.Clear();
            LlenarTree();
            LlenarView();
        }

        private void LlenarView()
        {
            string sql = "Show Databases;";
            DataTable dsa = new DataTable();
            MySqlDataAdapter msd = new MySqlDataAdapter(sql, con);
            msd.Fill(dsa);
            gvTablas.DataSource = dsa;
            
        }

        private DataTable LlenarGrid()
        {
            string sql = "Show Databases  ";
            DataSet ds = new DataSet();
            MySqlDataAdapter msda = new MySqlDataAdapter(sql, con);
            msda.Fill(ds, "TABLE_SCHEMA");
            return ds.Tables["TABLE_SCHEMA"];
        }
        private DataTable LlenarGrid(string var)
        {
            string sql = "Select TABLE_NAME from information_schema.tables where TABLE_SCHEMA = '"+ var+"' ;";
            DataSet dsa = new DataSet();
            MySqlDataAdapter msd = new MySqlDataAdapter(sql, con);           
            msd.Fill(dsa    , "TABLE_NAME");
            return dsa.Tables["TABLE_NAME"];
        }

        private void LlenarTree()
        {
            try
            {
                con.Open();
                trBD.Nodes.Clear();
                DataTable table = new DataTable();
                table = LlenarGrid();
                TreeNode padre = null;
                TreeNode hijo = null;
                if (table != null)
                {


                    foreach (DataRow dr in table.Rows)
                    {
                        padre = new TreeNode(dr.ItemArray[0].ToString());
                        //padre.Nodes.Add();    
                        DataTable dt = LlenarGrid(dr.ItemArray[0].ToString());
                        //trBD.Nodes.Add(padre);
                        /*
                        foreach (DataRow dr2 in dt.Rows)
                         {
                          hijo = new TreeNode(dr.ItemArray[0].ToString());
                          padre.Nodes.Add(hijo);

                         }*/
                        trBD.Nodes.Add(padre);
                    }

                }
                else MessageBox.Show("LOL");
                con.Close();
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void BtRefresh_Click(object sender, EventArgs e)
        {
            LlenarTree();
        }

        private void CrearToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void BtCrear_Click(object sender, EventArgs e)
        {
            using (CrearBD cr = new CrearBD(con))
            {
                if (cr.ShowDialog() == DialogResult.OK)
                {
                    LlenarGrid();
                }
            }
        }

        private void CrearTabla_Click(object sender, EventArgs e)
        {
            using (CrearTabla ct = new CrearTabla(con)) {
                if (ct.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private void EliminarTabla_Click(object sender, EventArgs e)
        {
            using (BorrarTabla bot = new BorrarTabla(con))
            {
               if(bot.ShowDialog() == DialogResult.OK)
                {
                    
                }
            }

        }

        private void ModificarTabla_Click(object sender, EventArgs e)
        {
            CrearTabla mon = new CrearTabla(con);
            mon.Show();
        }

        private void CrearIndice_Click(object sender, EventArgs e)
        {
            using(CrearIndice ci = new CrearIndice(con))
            {
                if (ci.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private void EliminarIndice_Click(object sender, EventArgs e)
        {
            using (BorrarIndice bri = new BorrarIndice(con)) {
                if (bri.ShowDialog() == DialogResult.OK)
                {

                }
            }
            
        }

        private void BtBorrar_Click(object sender, EventArgs e)
        {
            using (BorrarBD bbd = new BorrarBD(con))
            {
                if (bbd.ShowDialog() == DialogResult.OK) { LlenarTree(); }

            }
        }

        private void BtActualizar_Click(object sender, EventArgs e)
        {

            using (ModificarBD mbd = new ModificarBD(con))
            {
                if (mbd.ShowDialog() == DialogResult.OK ) {

                    LlenarTree();
                }
            }
        }

        private void CrearProcedimientos_Click(object sender, EventArgs e)
        {
            using (CrearText ct = new CrearText(con,"Procedure"))
            {
                if(ct.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private void CrearFunciones_Click(object sender, EventArgs e)
        {
            using (CrearText ct = new CrearText(con, "Function"))
            {
                if(ct.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private void CrearTrigger_Click(object sender, EventArgs e)
        {
            using (CrearText ct = new CrearText(con, "Trigger"))
            {
                if (ct.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private void EliminarProcedimiento_Click(object sender, EventArgs e)
        {
            using (BorrarText bt = new BorrarText(con, "Procedure"))
            {
                if (bt.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private void EliminarFuncion_Click(object sender, EventArgs e)
        {
            using (BorrarText bt = new BorrarText(con, "Function"))
            {
                if (bt.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private void BorrarTrigger_Click(object sender, EventArgs e)
        {
            using (BorrarText bt = new BorrarText(con, "Trigger"))
            {
                if (bt.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private void CrearCheck_Click(object sender, EventArgs e)
        {
            using (CrearCheck cc = new CrearCheck(con))
            {
                if (cc.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private void EliminarChecks_Click(object sender, EventArgs e)
        {
            using (BorrarIndice bi = new BorrarIndice(con))
            {
                if (bi.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private void BtCrearView_Click(object sender, EventArgs e)
        {
            using (CrearView cv = new CrearView(con))
            {
                if (cv.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private void BtBorrarView_Click(object sender, EventArgs e)
        {
            using(BorrarView bv = new BorrarView(con))
            {
                if(bv.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private void BtMostrar_Click(object sender, EventArgs e)
        {
            using (MostrarForm mf = new MostrarForm(con, "Tablas"))
            {
                if (mf.ShowDialog() == DialogResult.OK)
                {

                }

            }
        }

        private void BtUsers_Click(object sender, EventArgs e)
        {
            using (MostrarUsers mu = new MostrarUsers(con))
            {
                if (mu.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }
    }
}
