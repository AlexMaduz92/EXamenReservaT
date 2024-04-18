using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Datos.Entidades
{
    public class DReserva
    {
        [Key]
        public int ReservaId { get; set; }

        [ForeignKey("Cliente")]
        public int? ClienteId { get; set; }
        public virtual DCliente Cliente { get; set; }

        [ForeignKey("Teatro")]
        public int TeatroId { get; set; }
        public virtual DTeatro Teatro { get; set; }

        public DateTime FechaReserva { get; set; }
        public int AsientoN { get; set; }
    }
}
