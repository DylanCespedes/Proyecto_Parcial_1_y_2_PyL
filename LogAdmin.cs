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
    public partial class LogAdmin : Form
    {
        public LogAdmin()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdminIngresar_Click(object sender, EventArgs e)
        {
            string correoAdmin = "admin@mail.com";
            string passAdmin = "12345";

            if (this.txtCorreo.Text == correoAdmin && txtPassword.Text == passAdmin)
            {
                var btnAdminIngresar = new MenuAdministrador();
                this.Hide();
                btnAdminIngresar.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrecta!!!", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
