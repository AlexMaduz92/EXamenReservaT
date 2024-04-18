﻿using Datos.Core;
using Datos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Negocio
{
    public class NTeatro
    {
        private readonly IUnitOfWork _unitOfWork;

        public NTeatro(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<DTeatro>> ObtenerTodosTeatros()
        {
            return await _unitOfWork.TeatroIU.GetAllAsync();
        }

        public async Task<DTeatro> ObtenerTeatroPorId(int id)
        {
            return await _unitOfWork.TeatroIU.GetAsync(id);
        }

        public async Task AgregarTeatro(DTeatro teatro)
        {
            await _unitOfWork.TeatroIU.Agregar(teatro);
        }

        public async Task ActualizarTeatro(DTeatro teatro)
        {
            await _unitOfWork.TeatroIU.Actualizar(teatro);
        }

        public async Task EliminarTeatro(int id)
        {
            await _unitOfWork.TeatroIU.Eliminar(id);
        }

        public async Task GuardarCambios()
        {
            await _unitOfWork.SaveAsync();
        }
    }
}
