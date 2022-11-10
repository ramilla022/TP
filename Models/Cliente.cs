using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TP.Models
{
    public class Cliente
    {


        [Key]public int IdCliente { get; set; }
        public string nombre { get; set; }
        public int edad { get; set; }
        public int dni { get; set; }

          
    }
}
