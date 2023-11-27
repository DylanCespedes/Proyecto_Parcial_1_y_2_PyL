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
    public partial class MenuAdministrador : Form
    {
        public MenuAdministrador()
        {
            InitializeComponent();
        }

        private void btnCrearEstudiante_Click(object sender, EventArgs e)
        {
            var btnCrear = new CrearCuenta();
            this.Hide();
            btnCrear.ShowDialog();
            this.Show();
        }

        private void btnEditarEstudiante_Click(object sender, EventArgs e)
        {
            var btnEditar = new EditarEstudiante();
            this.Hide();
            btnEditar.ShowDialog();
            this.Show();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCursos_Click(object sender, EventArgs e)
        {
            var btnCursos = new Cursos();
            this.Hide();
            btnCursos.ShowDialog();
            this.Show();
        }
    }
}
