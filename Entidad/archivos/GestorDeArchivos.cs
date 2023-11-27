using Biblioteca_SYSACAD.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad.archivos
{
    public class GestorDeArchivos
    {
        static string nombreCarpeta = "Archivos";
        static string archivoEstudiante = "Estudiantes.json";
        static string archivoCursos = "Curso.json";

        public static List<Estudiante> LeerArchivoEstudiantes()
        {
            List<Estudiante> listaEstudiantes = new List<Estudiante>();

            string path = getUrlDocumentos();
            string urlCarpeta = CombinarUrl(path, nombreCarpeta);
            string urlArchivo = getUrlDocumentos();

            if (BuscarCarpetaArchivo(urlCarpeta))
            {
                urlArchivo = CombinarUrl(urlCarpeta, archivoEstudiante);
                if (!ValidarExistenciaArchivo(urlArchivo))
                {
                    crearArchivo(urlArchivo);
                }
            }

            return listaEstudiantes;
        }
        public static List<Curso> LeerArchivoJson()
        {
            List<Curso> cursos = new List<Curso>();

            string path = getUrlDocumentos();
            string urlCarpeta = CombinarUrl(path, nombreCarpeta);
            string urlArchivo = getUrlDocumentos();

            if (BuscarCarpetaArchivo(urlCarpeta))
            {
                urlArchivo = CombinarUrl(urlCarpeta, archivoCursos);
                if (!ValidarExistenciaArchivo(urlArchivo))
                {
                    crearArchivo(urlArchivo);
                }
            }

            return cursos;
        }

        protected static string LeerArchivo(string path)
        {
            string jsonResponse;
            using (StreamReader reader = new StreamReader(path))
            {
                jsonResponse = reader.ReadToEnd();
            }

            return jsonResponse;
        }

        protected static bool BuscarCarpetaArchivo(string urlCarpeta)
        {

            if (!Directory.Exists(urlCarpeta))
            {
                CrearCarpetaArchivo(urlCarpeta);
                return false;
            }
            return true;
        }

        private static string CombinarUrl(string path1, string path2)
        {
            return Path.Combine(path1, path2);
        }
        
        private static void CrearCarpetaArchivo(string urlPath)
        {
            Directory.CreateDirectory(urlPath);
        }

        private static bool ValidarExistenciaArchivo(string urlArchivo)
        {
            if (!File.Exists(urlArchivo))
            {
                return false;
            }
            return true;
        }

        private static string getUrlDocumentos()
        {
            Environment.SpecialFolder specialFolder = Environment.SpecialFolder.MyDocuments;
            return Environment.GetFolderPath(specialFolder);
        }

        private static void crearArchivo(string pathArchivo)
        {
            using (var writer = new StreamWriter(pathArchivo))
            {
                writer.WriteLine();
            }
        }

        private static void ReadStream(string file)
        {
            string carpeta = CombinarUrl(getUrlDocumentos(), nombreCarpeta);
            string archivo = carpeta + Path.DirectorySeparatorChar + file;

            if(!File.Exists(archivo)) 
            {
                File.Create(archivo).Close();
            }
            using (var reader = new StreamReader(archivo))
            {
                reader.ReadLine();
            }
            
        }
        
        
    
    }

}
