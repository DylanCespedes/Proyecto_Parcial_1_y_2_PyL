using Biblioteca_SYSACAD.Entidades;
using Entidad.archivos;
using Entidad.Clases_SYSACAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Entidad.Administracion
{
    public class Administracion
    {
        public static List<Administrador> ListaAdmins { get; set; }
        public static List<Curso> Listacursos { get; set; }
        public static List<Estudiante> ListaEstudiantes { get; set; }
        public static Estudiante EstudianteLogueado {  get; set; }


        public static void InicializarSistema()
        {
            JsonEstudiantes serializer = new JsonEstudiantes("C:\\Users\\nicoC\\Documents\\Archivos\\Estudiantes.json");
            Administracion.ListaEstudiantes = GestorDeArchivos.LeerArchivoEstudiantes();
            JsonCursos serializador = new JsonCursos("C:\\Users\\nicoC\\Documents\\Archivos\\Curso.json");
            Administracion.Listacursos = serializador.LeerCursosJson();
            Administracion.ListaEstudiantes = serializer.LeerEstudiantesJson();
        }

        public static void EliminarDatos(int cursoEliminar)
        {
            foreach (var curso in Administracion.Listacursos)
            {
                if (cursoEliminar == curso.CodigoCurso)
                {
                    Administracion.Listacursos.Remove(curso);
                    break;
                }

            }

            JsonCursos serializer = new JsonCursos("C:\\Users\\nicoC\\Documents\\Archivos\\Curso.json");
            serializer.GuardarCursosJson(Administracion.Listacursos);

        }

        public static void ModificarDatos(Curso cursoEditar, int codigoCursoModificar)
        {
            foreach (var curso in Administracion.Listacursos)
            {
                if(codigoCursoModificar == curso.CodigoCurso)
                {
                    curso.Nombre = cursoEditar.Nombre;
                    curso.Descripcion = cursoEditar.Descripcion;
                    curso.CodigoCurso = cursoEditar.CodigoCurso;
                    curso.horarioInicioFinal = cursoEditar.horarioInicioFinal;
                    curso.Aula = cursoEditar.Aula;
                    curso.CupoMax = cursoEditar.CupoMax;
                    break;
                }
            }

            JsonCursos serializer = new JsonCursos("C:\\Users\\nicoC\\Documents\\Archivos\\Curso.json");
            serializer.GuardarCursosJson(Administracion.Listacursos);

        }

        
    }
}
