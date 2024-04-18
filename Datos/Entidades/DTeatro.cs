using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entidades
{

        public class DTeatro
        {
        [Key]
        public int TeatroId { get; set; }
            public string NombreTeatro { get; set; }
            public int NumeroAsiento { get; set; }
            public virtual ICollection<DReserva> reserva { get; set; }
    }
}
