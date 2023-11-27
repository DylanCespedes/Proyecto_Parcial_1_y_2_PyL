using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sysacad
{
    public partial class ElegirMetodo : Form
    {
        public ElegirMetodo()
        {
            InitializeComponent();
        }

        private void btnTarjeta_Click(object sender, EventArgs e)
        {
            var btnTarjeta = new RealizarPaga();
            this.Hide();
            btnTarjeta.ShowDialog();
            this.Show();
        }

        private void btnTransferencia_Click(object sender, EventArgs e)
        {

        }
    }
}
