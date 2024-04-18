using Datos.Core;
using Datos.Entidades;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Datos.BaseDatos;

namespace Negocio
{
    public class NCliente
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepository<DCliente> _clienteRepository;

        public NCliente(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _clienteRepository = _unitOfWork.ClienteIU;
        }

        public async Task<IEnumerable<DCliente>> ObtenerTodosClientes()
        {
            return await Task.Run(() => _clienteRepository.ObtenerTodos());
        }

        public async Task<DCliente> ObtenerClientePorId(int id)
        {
            return await _unitOfWork.ClienteIU.GetAsync(id);
        }

        public async Task AgregarCliente(DCliente cliente)
        {
            await _unitOfWork.ClienteIU.Agregar(cliente);
        }

        public async Task ActualizarCliente(DCliente cliente)
        {
            await _unitOfWork.ClienteIU.Actualizar(cliente);
        }

        public async Task EliminarCliente(int id)
        {
            await _unitOfWork.ClienteIU.Eliminar(id);
        }

        public async Task GuardarCambios()
        {
            await _unitOfWork.SaveAsync();
        }
    }
}