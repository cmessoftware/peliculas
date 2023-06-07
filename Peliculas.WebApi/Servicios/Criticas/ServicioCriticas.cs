using Peliculas.WebApi.Entidades;
using Peliculas.UnitOfWorks;

namespace Peliculas.Servicios
{
    public class ServicioCriticas : IServicioCriticas
    {
        public IUnitOfWork _unitOfWork;

        public ServicioCriticas(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> Create(Critica critica)
        {
            if (critica != null)
            {
                await _unitOfWork.Criticas.Create(critica);

                var result = _unitOfWork.SaveChanges();

                return result > 0;
            }
            return false;
        }

        public async Task<bool> Delete(int? id)
        {
            if (id > 0)
            {
                return await _unitOfWork.Criticas.Delete(id);
            }
            return false;
        }

        public async Task<List<Critica>> GetAll()
        {
            var criticas = await _unitOfWork.Criticas.GetAll();
            return criticas;
        }

        public async Task<Critica> GetById(int? id)
        {
            if (id > 0)
            {
                var critica = await _unitOfWork.Criticas.GetById(id);
                if (critica != null)
                {
                    return critica;
                }
            }
            return null;
        }

        public async Task<bool> Update(Critica critica)
        {
            if (critica != null)
            {
                var criticaDB = await _unitOfWork.Criticas.GetById(critica.Id);
                if (criticaDB != null)
                {
                    criticaDB.Contenido = critica.Contenido;
                    criticaDB.Autor = critica.Autor;

                    await _unitOfWork.Criticas.Update(criticaDB);

                    var result = _unitOfWork.SaveChanges();

                    return result > 0;
                }
            }
            return false;
        }
    }
}
