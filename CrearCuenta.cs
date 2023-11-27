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
    public partial class CrearCuenta : Form
    {
        private Estudiante estudiante;


        public CrearCuenta()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            estudiante = new Estudiante(txtNombre.Text, txtBoxApellido.Text, Convert.ToDateTime(txtFecha.Text), Convert.ToInt32(txtDni.Text), txtDireccion.Text, Convert.ToInt32(txtTelefono.Text), Convert.ToString(txtContrasena.Text), txtCorreo.Text, checkContrasena.Checked);
            JsonEstudiantes serializer = new JsonEstudiantes("C:\\Users\\nicoC\\Documents\\Archivos\\Estudiantes.json");
            Administracion.ListaEstudiantes = serializer.LeerEstudiantesJson();
            Administracion.ListaEstudiantes.Add(estudiante);


            serializer.GuardarEstudiantesJson(Administracion.ListaEstudiantes);

            MessageBox.Show("!!!Se ha enviado un correo de verificacion a su buzon!!!");

            this.Close();
        }

        private void CrearCuenta_Load(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFecha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContrasena_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
