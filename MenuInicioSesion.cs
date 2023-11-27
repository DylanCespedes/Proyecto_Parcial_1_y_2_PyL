using Biblioteca_SYSACAD.Entidades;
using Entidad.Administracion;
using Entidad.archivos;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Logging;
using System.Text.Json;

namespace Sysacad
{
    public partial class formIniciar : Form
    {
        private List<Estudiante> estudiantes;

        public formIniciar()
        {
            InitializeComponent();
            estudiantes = new List<Estudiante>();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            var btnCrear = new CrearCuenta();
            this.Hide();
            btnCrear.ShowDialog();
            this.Show();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string jsonUbicacion = "C:\\Users\\nicoC\\Documents\\Archivos\\Estudiantes.json";

            if (File.Exists(jsonUbicacion))
            {
                string jsonContent = File.ReadAllText(jsonUbicacion);
                estudiantes = Administracion.ListaEstudiantes;

                string IngresoCorreo = txtCorreo.Text;
                string IngresoContrasena = txtContrasenia.Text;

                Estudiante estudianteVerificado = estudiantes.Find(e => e.Correo == IngresoCorreo && e.contrasena == IngresoContrasena);

                if (estudianteVerificado != null)
                {
                    Administracion.EstudianteLogueado = estudianteVerificado;

                    var btnIngresar = new MenuPrincipal();
                    this.Hide();
                    btnIngresar.ShowDialog();
                    this.Show();

                    txtCorreo.Clear();
                    txtContrasenia.Clear();
                }
                else
                {
                    MessageBox.Show("Correo y/o Contraseña invalido, Vuelve a intentarlo", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnLogAdmin_Click(object sender, EventArgs e)
        {
            var btnLogAdmin = new LogAdmin();
            this.Hide();
            btnLogAdmin.ShowDialog();
            this.Show();
        }

        private void formIniciar_Load(object sender, EventArgs e)
        {
            Administracion.InicializarSistema();

        }

    }
}