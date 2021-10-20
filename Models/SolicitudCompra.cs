using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace simulacro_vite.Models
{
    public class SolicitudCompra
    {
        public int Id{get;set;}
        
        public DateTime Fecha {get; set;}


        //  Nos indica a que producto pertenece la solicitud
        public string Producto {get; set;}

        public double Precio{get; set;}

        public string Categoria{ get; set;}

        public Usuario Usuario{get; set;}

        public int UsuarioId{ get; set;}

        // Constructor
        public SolicitudCompra(){
            //Tome la fecha del sistema
            Fecha = DateTime.Now;
        }
        
    }
}