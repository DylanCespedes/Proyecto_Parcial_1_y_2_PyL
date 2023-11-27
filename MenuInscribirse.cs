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
    public partial class MenuInscribirse : Form
    {
        private Curso cursoSeleccionado;

        public MenuInscribirse()
        {
            InitializeComponent();
        }

        private void MenuInscribirse_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Administracion.Listacursos;
        }

        private void btnInscribirse_Click(object sender, EventArgs e)
        {

            cursoSeleccionado = (Curso)dataGridView1.SelectedRows[0].DataBoundItem;

            //string codigo = dataGridView1.SelectedRows[0].Cells["codigoCurso"].Value.ToString();

            DialogResult resultado = MessageBox.Show("Quieres inscribirte a este curso?", "Aviso!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Estudiante estudianteData = Administracion.EstudianteLogueado;
                if (estudianteData.ListaCursos is null)
                {
                    estudianteData.ListaCursos = new List<string>();
                }

                bool inscripcionHecha = estudianteData.InscribirseACurso(cursoSeleccionado);

                if (inscripcionHecha)
                {
                    JsonEstudiantes serializer = new JsonEstudiantes("C:\\Users\\nicoC\\Documents\\Archivos\\Estudiantes.json");
                    serializer.GuardarEstudiantesJson(Administracion.ListaEstudiantes);
                    List<Curso> prueba = dataGridView1.DataSource as List<Curso>;
                    JsonCursos serializador = new JsonCursos("C:\\Users\\nicoC\\Documents\\Archivos\\Curso.json");
                    serializador.GuardarCursosJson(prueba);

                    MessageBox.Show("Inscripcion completada!!!", "Aviso!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se puede inscribirse a este curso, es posible que ya estes inscripto o los cupos esten acabados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
