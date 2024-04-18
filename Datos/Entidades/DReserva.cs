using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entidades
{
    public class DReserva
    {
        [Key]
        public int ReservaId{ get; set; }
        public DateTime FechaReserva { get; set; }
        public int TeatroId { get; set; }
        public int CienteId { get; set; }
        public int AsientoN { get; set; }

        public virtual DTeatro teatro { get; set; }
        public virtual DCliente cliente { get; set; }
    }
}
