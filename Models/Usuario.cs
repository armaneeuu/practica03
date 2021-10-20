using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using simulacro_vite.Controllers;

namespace simulacro_vite.Models
{
    public class Usuario
    {
        public int Id{get; set;}
        [Required]
        public string Nombre{get; set;}

        [Required]
        public string Celular{get; set;}

        

        // Vinculo 1 usuario muchas solicitudes
        public ICollection<SolicitudCompra> Solicitudes {get; set;}
    }
}