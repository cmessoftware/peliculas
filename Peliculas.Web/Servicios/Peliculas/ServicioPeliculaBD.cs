using AutoMapper;
using Peliculas.Entidades;
using Peliculas.UnitOfWorks;
using Peliculas.Web.ViewModels;

namespace Peliculas.Servicios.Peliculas
{
    public class ServicioPeliculaDB : IServicioPelicula
    {
        public IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<ServicioPeliculaDB> _logger;

        public ServicioPeliculaDB(IUnitOfWork unitOfWork,
                                  IMapper mapper, 
                                  ILogger<ServicioPeliculaDB> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<bool> Create(PeliculaViewModel peliculaDto)
        {
            if (peliculaDto != null)
            {

                var pelicula = _mapper.Map<Pelicula>(peliculaDto);

                await _unitOfWork.Peliculas.Create(pelicula);

                return  _unitOfWork.SaveChanges() > 0;
            }
            return false;
        }

        public async Task<bool> Delete(int? id)
        {
            if (id > 0)
            {
                var pelicula = await _unitOfWork.Peliculas.GetById(id);
                if (pelicula != null)
                {
                    await _unitOfWork.Peliculas.Delete(id);

                    return _unitOfWork.SaveChanges() > 0;
                }
            }
            return false;
        }

        public async Task<List<PeliculaViewModel>> GetAll()
        {
            var peliculas = await _unitOfWork.Peliculas.GetAll();

            var peliculasDto = new List<PeliculaViewModel>();

            foreach (var peli in peliculas)
            {
                var peliculaDto = _mapper.Map<PeliculaViewModel>(peli);
                peliculasDto.Add(peliculaDto);
            }

            return peliculasDto;
        }

        public async Task<PeliculaViewModel> GetById(int? id)
        {
            if (id > 0)
            {
                var pelicula = await _unitOfWork.Peliculas.GetById(id);
                if (pelicula != null)
                {
                    var peliculaVM = _mapper.Map<PeliculaViewModel>(pelicula);
                    return peliculaVM;
                }
            }
            return null;
        }

        public async Task<bool> Update(PeliculaViewModel peliculaDto)
        {
            if (peliculaDto != null)
            {
                var pelicula = await _unitOfWork.Peliculas.GetById(peliculaDto.Id);
                if (pelicula != null)
                {

                    pelicula = _mapper.Map<Pelicula>(peliculaDto);
                    await _unitOfWork.Peliculas.Update(pelicula);
                    var result = _unitOfWork.SaveChanges();

                    return result > 0;
                }
            }
            return false;
        }

        Task<Pelicula> IServicioGenerico<Pelicula>.GetById(int? id)
        {
            throw new NotImplementedException();
        }

        Task<List<Pelicula>> IServicioGenerico<Pelicula>.GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Create(Pelicula entity)
        {
            return await _unitOfWork.Peliculas.Create(entity);
        }

        public Task<bool> Update(Pelicula entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteConfirmed(int? id)
        {
            throw new NotImplementedException();
        }
    }
}
