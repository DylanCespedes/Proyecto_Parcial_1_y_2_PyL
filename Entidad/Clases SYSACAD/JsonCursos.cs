using Biblioteca_SYSACAD.Entidades;
using Entidad.Administracion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Entidad.Clases_SYSACAD
{
    public class JsonCursos
    {
        private string urlFullPath;

        public JsonCursos(string path)
        {
            this.urlFullPath = path;
        }

        public void GuardarCursosJson(List<Curso> listaCursos)
        {
            JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions();
            jsonSerializerOptions.WriteIndented = true;
            var json = JsonSerializer.Serialize(listaCursos, jsonSerializerOptions);
            

            using (var writer = new StreamWriter(this.urlFullPath))
            {
                writer.WriteLine(json);
            }

        }

        public List<Curso> LeerCursosJson()
        {
            using (var reader = new StreamReader(this.urlFullPath))
            {
                string listaSerializada = reader.ReadToEnd();
                List<Curso> listaCursos = JsonSerializer.Deserialize<List<Curso>>(listaSerializada);

                return listaCursos;
            }

        }
    }
}
