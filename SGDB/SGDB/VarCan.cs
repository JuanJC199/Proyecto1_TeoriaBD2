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
    public partial class VarCan : Form
    {
        public string numero;
        public VarCan()
        {
            InitializeComponent();
        }

        private void BtOk_Click(object sender, EventArgs e)
        {
            numero = txtNumber.Text;
            this.DialogResult = DialogResult.OK;
        }
    }
}
