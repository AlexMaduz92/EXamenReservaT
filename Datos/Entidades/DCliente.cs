using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entidades
{
    public class DCliente
    {
        [Key]
        [Required]
        public int ClienteId { get; set; }
        public string Nombres{ get; set; }
        public string Apellidos{ get; set; }
        public decimal Identidad { get; set; }  
        public string Correo { get; set; }
        public int Celular { get; set; }    

    }
}
