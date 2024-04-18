using Datos.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Core
{
    public class ClienteRepository : IRepository<DCliente>
    {
        private readonly DbContext _context;

        public ClienteRepository(DbContext context)
        {
            _context = context;
        }

        public IEnumerable<DCliente> ObtenerTodos()
        {
            return _context.Set<DCliente>().ToList();
        }
    }
}
