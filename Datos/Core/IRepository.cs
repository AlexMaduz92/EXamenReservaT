using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Core
{
    public interface IRepository<T> where T : class
    {
        Task<T> GetAsync(int id);
        IEnumerable<T> ObtenerTodos();
        Task Agregar(T entity);
        Task Actualizar(T entity);
        Task Eliminar(int id);
    }
}
