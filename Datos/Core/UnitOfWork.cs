using Datos.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Datos.BaseDatos
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext _context;

        public UnitOfWork(DbContext context)
        {
            _context = context;
            TeatroIU = new Repository<DTeatro>(_context);
            ClienteIU = new Repository<DCliente>(_context);
            ReservaIU = new Repository<DReserva>(_context);
        }

        public Repository<DTeatro> TeatroIU { get; private set; }
        public Repository<DCliente> ClienteIU { get; private set; }
        public Repository<DReserva> ReservaIU { get; private set; }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}