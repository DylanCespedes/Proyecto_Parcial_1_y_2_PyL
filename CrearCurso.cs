using Biblioteca_SYSACAD.Entidades;
using Entidad.Administracion;
using Entidad.Clases_SYSACAD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sysacad
{
    public partial class CrearCurso : Form
    {
        private List<Estudiante> estudiantes;

        public CrearCurso()
        {
            InitializeComponent();
            estudiantes = new List<Estudiante>();
        }

        private void btnCrear_Click(object sender, EventArgs e)
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
                JsonCursos serializer = new JsonCursos("C:\\Users\\nicoC\\Documents\\Archivos\\Curso.json");
                Administracion.Listacursos = serializer.LeerCursosJson();
                Administracion.Listacursos.Add(curso);

                serializer.GuardarCursosJson(Administracion.Listacursos);

                this.Close();
            }
            else
            {
                MessageBox.Show("Codigo de clase ya existente y/o creada", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }
    }
}
