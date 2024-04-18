using Datos.Core;
using Datos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Negocio
{
    public class NReserva
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepository<DReserva> _reservaRepository;

        public NReserva(IUnitOfWork unitOfWork, IRepository<DReserva> reservaRepository)
        {
            _unitOfWork = unitOfWork;
            _reservaRepository = reservaRepository;
        }

        public async Task<DReserva> CrearReserva(DReserva reserva)
        {
            // Implementar la lógica de negocio para crear una nueva reserva
            await _unitOfWork.ReservaIU.Agregar(reserva);
            await _unitOfWork.SaveAsync();
            return reserva;
        }

        public async Task<DReserva> ObtenerReserva(int id)
        {
            // Implementar la lógica de negocio para obtener una reserva por su ID
            return await _unitOfWork.ReservaIU.GetAsync(id);
        }

        public async Task<IEnumerable<DReserva>> ObtenerReservas()
        {
            // Implementar la lógica de negocio para obtener todas las reservas
            return await _unitOfWork.ReservaIU.GetAllAsync();
        }

        public async Task<DReserva> ActualizarReserva(DReserva reserva)
        {
            await _unitOfWork.ReservaIU.Actualizar(reserva);
            await _unitOfWork.SaveAsync();
            return reserva;
        }

        public async Task EliminarReserva(int id)
        {
            var reserva = await _reservaRepository.GetAsync(id);
            if (reserva != null)
            {
                await _reservaRepository.Eliminar(id);
            }
            else
            {
                throw new ArgumentException("La reserva no existe");
            }
        }
    }
}