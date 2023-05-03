using Peliculas.Entidades;
using Peliculas.UnitOfWorks;

namespace Peliculas.Servicios
{
    public class ServicioGeneros : IServicioGeneros
    {
        public IUnitOfWork _unitOfWork;

        public ServicioGeneros(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> Create(Genero genero)
        {
            if (genero != null)
            {
                await _unitOfWork.Generos.Create(genero);

                var result = _unitOfWork.SaveChanges();

                return result > 0 ? true : false;
            }
            return false;
        }

        public async Task<bool> Delete(int? id)
        {
            if (id != null)
            {
                return await _unitOfWork.Generos.Delete(id);
            }
            return false;
        }

        public Task<bool> DeleteConfirmed(int? id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Genero>> GetAll()
        {
            var generos = await _unitOfWork.Generos.GetAll();
            return generos;
        }

        public async Task<Genero> GetById(int? id)
        {
            if (id > 0)
            {
                var genero = await _unitOfWork.Generos.GetById(id);
                if (genero != null)
                {
                    return genero;
                }
            }
            return null;
        }


        public async Task<bool> Update(Genero genero)
        {
            if (genero != null)
            {
                var generosDB = await _unitOfWork.Generos.GetById(genero.Id);
                if (generosDB != null)
                {
                    //comentarioDB.Contenido = genero.Contenido;
                    //comentarioDB.Usuario = genero.Usuario;

                    await _unitOfWork.Generos.Update(generosDB);

                    var result = _unitOfWork.SaveChanges();

                    return result > 0;
                }
            }
            return false;
        }
    }
}
