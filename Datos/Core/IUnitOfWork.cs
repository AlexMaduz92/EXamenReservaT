using Datos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Core
{
    public interface IUnitOfWork
    {
        Repository<DTeatro> TeatroIU { get; }
        Repository<DCliente> ClienteIU { get; }
        Repository<DReserva> ReservaIU { get; }

        Task SaveAsync();
    }
}
