using Datos.Entidades;
using Datos.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.BaseDatos;

namespace Datos.BaseDatos
{
    public interface IUnitOfWork
    {

        Repository<DTeatro> TeatroIU { get; }
        Repository<DCliente> ClienteIU { get; }
        Repository<DReserva> ReservaIU { get; }

        Task SaveAsync();
    }
}
