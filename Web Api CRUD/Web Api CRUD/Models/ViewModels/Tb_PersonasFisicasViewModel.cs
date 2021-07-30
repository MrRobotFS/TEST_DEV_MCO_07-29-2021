using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web_Api_CRUD.Models.ViewModels
{
    public class Tb_PersonasFisicasViewModel
    {
        public int IdPersonaFisica { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Registro")]
        public DateTime FechaRegistro { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Apellido Paterno")]
        public string ApellidoPaterno { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Apellido Materno")]
        public string ApellidoMaterno { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "RFC")]
        public string RFC { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Nacimiento")]
        public DateTime FechaNacimiento { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Quien Agrega?")]
        public int UsuarioAgrega { get; set; }
        [Required]
        [Display(Name = "Status")]
        public Boolean Activo { get; set; }
    }
}