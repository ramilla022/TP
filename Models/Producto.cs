using TP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TP.Models
{
    public class Producto
    {

        public String Marca { get; set; }
        public TipoDeProducto tipoDeProducto { get; set; }

        [Key]
        public int Id { get; set; }
        public int Stock { get; set; }

    }
}
