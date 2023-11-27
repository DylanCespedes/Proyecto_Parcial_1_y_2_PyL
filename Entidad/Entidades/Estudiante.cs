using System.Globalization;

namespace Biblioteca_SYSACAD.Entidades
{
    public class Estudiante : Administrador
    {
        public string Direccion { get; set; }
        public int Dni { get; set; }
        public Guid idEstudiante { get; set; }
        public int Telefono { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public bool PassProvicional { get; set; }
        public string contrasena { get; set; }
        public List<string> ListaCursos {  get; set; }

        public Estudiante(string nombre, string apellido, DateTime fechaNacimiento, int dni, string direccion, int telefono, string contrasena, string correo, bool passProvicional)
        {
            Direccion = direccion;
            Dni = dni;
            Telefono = telefono;
            Nombre = nombre;
            Apellido = apellido;
            PassProvicional = passProvicional;
            ListaCursos = new List<string>();
            Correo = correo;
            this.contrasena = contrasena;
            this.fechaNacimiento = fechaNacimiento;

            idEstudiante = Guid.NewGuid();
        }

        public Estudiante(int legajo, string direccion, string dni, int telefono, string nombre, string apellido, bool passProvicional) : base()
        {
            idEstudiante = idEstudiante;
        }

        public Estudiante()
        {

        }

        public bool InscribirseACurso(Curso curso)
        {

            if (curso.ListaEstudiantes.Count < curso.CupoMax)
            {

                foreach (var item in curso.ListaEstudiantes)
                {
                    if (item.Correo == this.Correo)
                    {
                        return false;
                    }
                }

                ListaCursos.Add(curso.Nombre);
                curso.ListaEstudiantes.Add(this);

                return true;
            }
            return false;
        }

        public bool EliminarCurso(string nombre)
        {

            foreach (var item in ListaCursos)
            {
                if (item == nombre)
                {
                    ListaCursos.Remove(item);
                    return true;
                }
                break;
            }
            return false;
        }
        
    }
}