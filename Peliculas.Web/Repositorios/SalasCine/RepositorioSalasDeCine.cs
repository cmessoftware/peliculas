using Peliculas.Entidades;
using Peliculas.Web.Repositorios.Clientes;

namespace Peliculas.Web.Repositorios.SalasCine
{
    internal class RepositorioSalasDeCine : IRepositorioSalasDeCine
    {
        public Task<bool> Create(SalaCine entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteConfirmed(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<List<SalaCine>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<SalaCine> GetById(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(SalaCine entity)
        {
            throw new NotImplementedException();
        }
    }
}