﻿using Peliculas.UnitOfWorks;
using Peliculas.WebApi.Entidades;

namespace Peliculas.Servicios
{
    public interface IServicioEntradas : IServicioGenerico<Entrada>
    {
        Task<bool> Create(Entrada entrada);

        Task<List<Entrada>> GetAll();

        Task<Entrada> GetById(int? id);

        Task<bool> Update(Entrada entrada);

        Task<bool> Delete(int? id);
    }
}
