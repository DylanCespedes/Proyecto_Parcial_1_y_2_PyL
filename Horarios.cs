using Biblioteca_SYSACAD.Entidades;
using Entidad.Administracion;
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
    public partial class Horarios : Form
    {
        public Horarios()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Horarios_Load(object sender, EventArgs e)
        {
            List<string> horarios = new List<string>();
            foreach (Curso curso in Administracion.Listacursos)
            {
                if (Administracion.EstudianteLogueado.ListaCursos.Contains(curso.Nombre))
                {
                    horarios.Add(curso.horarioInicioFinal);
                }
            }

            listBox1.DataSource = horarios;
        }
    }
}
