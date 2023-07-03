﻿using Movies.UnitOfWorks;
using Movies.WebApi.Data;
using Movies.WebApi.Entities;


namespace Movies.Data.Repositorios.Actores
{
    public class RepositorioActores : RepositorioGenerico<Actor>, IRepositorioActores
    {
        private readonly ILogger _logger;
        private readonly MovieDbContext _context;

        public RepositorioActores(ILogger<RepositorioActores> logger, MovieDbContext context) : base(logger,
                                                                                                         context)
        {
            this._logger = logger;
            this._context = context;
        }

        public async Task<bool> Create(Actor entity)
        {
            return await base.Create(entity);
        }

        public async Task<bool> Delete(int? id)
        {

            return await base.Delete(id);
        }

        public async Task<List<Actor>> GetAll()
        {
            return await base.GetAll();
        }

        public async Task<Actor> GetById(int? id)
        {
            return await base.GetById(id);
        }

        public async Task<bool> Update(Actor entity)
        {
            return await base.Update(entity);
        }
    }
}