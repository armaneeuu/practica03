using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace simulacro_vite.Models
{
    public class Producto
    {
        public int Id{get; set;}

        public string NombreProducto{get; set;}

        public string foto{get; set;}

        public double Precio{get; set;}

        public string Celular{get; set;}

        public Categoria Categoria{get; set;}

        public ICollection<SolicitudCompra> Solicitudes {get; set;}

    }
}