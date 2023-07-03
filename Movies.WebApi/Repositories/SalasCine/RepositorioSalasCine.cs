using Movies.UnitOfWorks;
using Movies.WebApi.Data;
using Movies.WebApi.Entities;

namespace Movies.Data.Repositorios
{
    public class RepositorioSalasCine : RepositorioGenerico<RoomCinema>, IRepositorioSalasCine
    {
        private readonly ILogger _logger;
        private readonly MovieDbContext _context;

        public RepositorioSalasCine(ILogger<RepositorioSalasCine> logger, MovieDbContext context) : base(logger,
                                                                                     context)
        {
            this._logger = logger;
            this._context = context;
        }

        public Task<bool> Create(RoomCinema entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<List<RoomCinema>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<RoomCinema> GetById(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(RoomCinema entity)
        {
            throw new NotImplementedException();
        }
    }
}