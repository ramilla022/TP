using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TP.Models
{
    public class Venta
    {   
       [Key] public int idVenta {get;set;}
        public DateTime fecha { get; set; }
        public Producto producto { get; set; }
        public Cliente cliente { get; set; }

    }
}
