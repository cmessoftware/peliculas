using Movies.UnitOfWorks;
using Movies.WebApi.Data;
using Movies.WebApi.Entities;

namespace Movies.Data.Repositorios
{
    public class RepositorioUbicacionesEnSala : RepositorioGenerico<RoomCinemaLocation>, IRepositorioUbicacionesEnSala
    {

        private readonly ILogger _logger;
        private readonly MovieDbContext _context;

        public RepositorioUbicacionesEnSala(ILogger<RepositorioUbicacionesEnSala> logger, MovieDbContext context) : base(logger,
                                                                                     context)
        {
            this._logger = logger;
            this._context = context;
        }

        public Task<bool> Create(RoomCinemaLocation entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<List<RoomCinemaLocation>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<RoomCinemaLocation> GetById(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(RoomCinemaLocation entity)
        {
            throw new NotImplementedException();
        }
    }
}