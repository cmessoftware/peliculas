using Peliculas.WebApi.Entidades;
using Peliculas.UnitOfWorks;

namespace Peliculas.Servicios
{
    public class ServicioEntradas : IServicioEntradas
    {
        public IUnitOfWork _unitOfWork;

        public ServicioEntradas(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> Create(Entrada entrada)
        {
            if (entrada != null)
            {
                await _unitOfWork.Entradas.Create(entrada);

                var result = _unitOfWork.SaveChanges();

                return result > 0;
            }
            return false;
        }

        public async Task<bool> Delete(int? id)
        {
            if (id != null)
            {
                return await _unitOfWork.Entradas.Delete(id);
            }
            return false;
        }

        public async Task<List<Entrada>> GetAll()
        {
            var entradas = await _unitOfWork.Entradas.GetAll();
            return entradas;
        }

        public async Task<Entrada> GetById(int? id)
        {
            if (id > 0)
            {
                var entrada = await _unitOfWork.Entradas.GetById(id);
                if (entrada != null)
                {
                    return entrada;
                }
            }
            return null;
        }

        public async Task<bool> Update(Entrada entrada)
        {
            if (entrada != null)
            {
                var entradaDB = await _unitOfWork.Entradas.GetById(entrada.Id);
                if (entradaDB != null)
                {
                    //entradaDB.Contenido = entrada.Contenido;
                    //entradaDB.Usuario = entrada.Usuario;

                    await _unitOfWork.Entradas.Update(entradaDB);

                    var result = _unitOfWork.SaveChanges();

                    return result > 0;
                }
            }
            return false;
        }
    }
}
