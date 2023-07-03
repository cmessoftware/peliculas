using Movies.UnitOfWorks;
using Movies.WebApi.Entities;

namespace Movies.Servicios
{
    public class ServicioSalasCine : IServicioSalasCine
    {
        public IUnitOfWork _unitOfWork;

        public ServicioSalasCine(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> Create(RoomCinema salaCine)
        {
            if (salaCine != null)
            {
                await _unitOfWork.SalasDeCine.Create(salaCine);

                var result = _unitOfWork.SaveChanges();

                return result > 0;
            }
            return false;
        }

        public async Task<bool> Delete(int? id)
        {
            if (id > 0)
            {
                return await _unitOfWork.SalasDeCine.Delete(id);
            }
            return false;
        }

        public Task<bool> Delete(RoomCinema salaCine)
        {
            throw new NotImplementedException();
        }


        public async Task<List<RoomCinema>> GetAll()
        {
            var salaCine = await _unitOfWork.SalasDeCine.GetAll();
            return salaCine;
        }

        public async Task<RoomCinema> GetById(int? id)
        {
            if (id != null)
            {
                var salaCine = await _unitOfWork.SalasDeCine.GetById(id);
                if (salaCine != null)
                {
                    return salaCine;
                }
            }
            return null;
        }

        public async Task<bool> Update(RoomCinema sc)
        {
            if (sc != null)
            {
                var salaCineBD = await _unitOfWork.SalasDeCine.GetById(sc.Id);
                if (salaCineBD != null)
                {
                    //comentarioDB.Contenido = sc.Contenido;
                    //comentarioDB.Usuario = sc.Usuario;

                    await _unitOfWork.SalasDeCine.Update(salaCineBD);

                    var result = _unitOfWork.SaveChanges();

                    return result > 0;
                }
            }
            return false;
        }
    }
}
