using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_Api_CRUD.Models.ViewModels
{
    public class ListTb_PersonasFisicasViewModel
    {
        //Data type source https://stackoverflow.com/questions/425389/c-sharp-equivalent-of-sql-server-datatypes 

        public int IdPersonaFisica { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime FechaActualizacion { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string RFC { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int UsuarioAgrega { get; set; }
        public Boolean Activo { get; set; }
    }
}