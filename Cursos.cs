using Biblioteca_SYSACAD.Entidades;
using Entidad.Administracion;
using Entidad.archivos;
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
    public partial class Cursos : Form
    {
        public Cursos()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            var btnCrear = new CrearCurso();
            this.Hide();
            btnCrear.ShowDialog();
            dataGridView1.DataSource = Administracion.Listacursos;
            this.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            var columna = dataGridView1.Columns["codigoCurso"];

            DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0];

            int indiceColumna = dataGridView1.Columns["codigoCurso"].Index;

            object valorCelda = filaSeleccionada.Cells[indiceColumna].Value;

            Curso cursoEncontrado = Administracion.Listacursos.Find(x => x.CodigoCurso == (int)valorCelda);

            var btnCrear = new EditarCurso(cursoEncontrado);
            this.Hide();
            btnCrear.ShowDialog();
            this.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {

                string codigo = dataGridView1.SelectedRows[0].Cells["CodigoCurso"].Value.ToString();

                DialogResult result = MessageBox.Show("Estas seguro que quieres eliminar este curso?", "Aviso!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Administracion.EliminarDatos(Convert.ToInt32(codigo));
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = Administracion.Listacursos;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Selecciona un curso para eliminar", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cursos_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Administracion.Listacursos;
        }
    }
}
