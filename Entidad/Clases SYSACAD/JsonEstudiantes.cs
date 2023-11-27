using Biblioteca_SYSACAD.Entidades;
using Entidad.archivos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entidad.Clases_SYSACAD
{
    public class JsonEstudiantes
    {
        private string urlFullPath;

        public JsonEstudiantes(string urlFullPath)
        {
            this.urlFullPath = urlFullPath;
        }

        public void GuardarEstudiantesJson(List<Estudiante> listaEstudiantes)
        {
            JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions();
            jsonSerializerOptions.WriteIndented = true;
            var json = JsonSerializer.Serialize(listaEstudiantes, jsonSerializerOptions);
            
            using (var writer = new StreamWriter(this.urlFullPath)) 
            {
                writer.WriteLine(json);
            }

        }

        public List<Estudiante> LeerEstudiantesJson()
        {
            using (var reader = new StreamReader(this.urlFullPath))
            {
                string listaSerializada = reader.ReadToEnd();
                List<Estudiante> listaEstudiantes = JsonSerializer.Deserialize<List<Estudiante>>(listaSerializada);

                return listaEstudiantes;
            }

        }

    }
}
