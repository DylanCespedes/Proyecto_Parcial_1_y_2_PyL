using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_SYSACAD.Entidades
{
    public class Curso
    {

        public string Nombre { get; set; }


        public int CodigoCurso { get; set; }


        public List<Estudiante> ListaEstudiantes {  get; set; }


        public string Descripcion { get; set; }


        public string horarioInicioFinal {  get; set; }

        public string Aula {  get; set; }

        public int CupoMax { get; set; }

        public Curso() { }

        public Curso(string nombre, int codigoCurso, string descripcion, string horario, string aula, int cupoMax) 
        {
            Nombre = nombre;
            CodigoCurso = codigoCurso;
            horarioInicioFinal = horario;
            Aula = aula;
            Descripcion = descripcion;
            CupoMax = cupoMax;

            this.ListaEstudiantes = new List<Estudiante>();
        }

    }
}
