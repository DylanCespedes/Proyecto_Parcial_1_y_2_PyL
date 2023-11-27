using Biblioteca_SYSACAD.Entidades;
using Entidad.Administracion;
using Entidad.Clases_SYSACAD;
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
    public partial class EditarCurso : Form
    {
        private Curso cursoModificar;

        public EditarCurso(Curso cursoModificar)
        {
            InitializeComponent();
            this.cursoModificar = cursoModificar;
            txtNombre.Text = cursoModificar.Nombre;
            txtCodigo.Text = cursoModificar.CodigoCurso.ToString();
            txtDescripcion.Text = cursoModificar.Descripcion;
            int cantidadMaxima = (int)numbCupo.Value;
            txtHorario.Text = cursoModificar.horarioInicioFinal.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            int codigo = Convert.ToInt32(txtCodigo.Text);
            string descripcion = txtDescripcion.Text;
            string horario = txtHorario.Text;
            string aula = txtAula.Text;
            int cantidadMaxima = (int)numbCupo.Value;

            Curso curso = new Curso(nombre, codigo, descripcion, horario, aula, cantidadMaxima);

            bool cursoExistente = Administracion.Listacursos.Any(c => c.CodigoCurso == curso.CodigoCurso);

            if (!cursoExistente)
            {
                Administracion.ModificarDatos(curso, cursoModificar.CodigoCurso);

                this.Close();
            }
            else
            {
                MessageBox.Show("El codigo ya existe", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
