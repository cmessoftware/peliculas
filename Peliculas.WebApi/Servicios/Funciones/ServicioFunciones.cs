using Peliculas.UnitOfWorks;
using Peliculas.WebApi.Entidades;

namespace Peliculas.Servicios
{
    public class ServicioFunciones : IServicioFunciones
    {
        public IUnitOfWork _unitOfWork;

        public ServicioFunciones(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> Create(Funcion funcion)
        {
            if (funcion != null)
            {
                await _unitOfWork.Funciones.Create(funcion);

                var result = _unitOfWork.SaveChanges();

                return result > 0;
            }
            return false;
        }

        public async Task<bool> Delete(int? id)
        {
            if (id != 0)
            {
                var funcion = await _unitOfWork.Funciones.GetById(id);
                if (funcion != null)
                {
                    return await _unitOfWork.Funciones.Delete(id);
                }
            }
            return false;
        }

        public async Task<List<Funcion>> GetAll()
        {
            var funcions = await _unitOfWork.Funciones.GetAll();
            return funcions;
        }

        public async Task<Funcion> GetById(int? id)
        {
            if (id > 0)
            {
                var funcion = await _unitOfWork.Funciones.GetById(id);
                if (funcion != null)
                {
                    return funcion;
                }
            }
            return null;
        }

        public async Task<bool> Update(Funcion funcion)
        {
            if (funcion != null)
            {
                var funcionDB = await _unitOfWork.Funciones.GetById(funcion.Id);
                if (funcionDB != null)
                {
                    //funcionDB.Contenido = funcion.Contenido;
                    //funcionDB.Usuario = funcion.Usuario;

                    await _unitOfWork.Funciones.Update(funcionDB);

                    var result = _unitOfWork.SaveChanges();

                    return result > 0;
                }
            }
            return false;
        }
    }
}
