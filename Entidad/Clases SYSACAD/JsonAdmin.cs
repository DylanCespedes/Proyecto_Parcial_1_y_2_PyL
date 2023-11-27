using Biblioteca_SYSACAD.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Entidad.Clases_SYSACAD
{
    public class JsonAdmin
    {
        private string urlFullPath;

        public JsonAdmin(string path)
        {
            this.urlFullPath = path;
        }

        public void GuardarAdministradorJson(List<Administrador> listaAdministrador)
        {
            JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions();
            jsonSerializerOptions.WriteIndented = true;
            var json = JsonSerializer.Serialize(listaAdministrador, jsonSerializerOptions);

            using (var writer = new StreamWriter(this.urlFullPath))
            {
                writer.WriteLine(json);
            }

        }

        public List<Administrador> LeerAdministradorJson()
        {
            using (var reader = new StreamReader(this.urlFullPath))
            {
                string listaSerializada = reader.ReadToEnd();
                List<Administrador> listaAdministrador = JsonSerializer.Deserialize<List<Administrador>>(listaSerializada);

                return listaAdministrador;
            }

        }
    }
}
