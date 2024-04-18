using Datos.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Datos.BaseDatos
{
    public class ExaIIRTeatroConec : DbContext
    {
        public ExaIIRTeatroConec() : base("name=ExaIIRAD")
        {

        }
        public DbSet<DTeatro> teatro { get; set; }
        public DbSet<DCliente> cliente { get; set; }
        public DbSet<DReserva> reserva { get; set; }

    }
}
