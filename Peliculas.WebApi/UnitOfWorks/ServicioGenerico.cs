namespace Peliculas.UnitOfWorks
{
    public abstract class ServicioGenerico<TEntity> : IServicioGenerico<TEntity> where TEntity : class
    {
        private readonly IRepositorioGenerico<TEntity> _repoGenerico;

        public ServicioGenerico(IRepositorioGenerico<TEntity> repoGenerico)
        {
            this._repoGenerico = repoGenerico;
        }


        public async Task<bool> Create(TEntity entity)
        {
            //TODO: Setera datos de auditoria.

            return await _repoGenerico.Create(entity);
        }

        public async Task<bool> Delete(int? id)
        {
            //TODO: Setera datos de auditoria.
            return await _repoGenerico.Delete(id);
        }

        public Task<bool> DeleteConfirmed(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<List<TEntity>> GetAll()
        {
            //TODO: Setera datos de auditoria.
            return _repoGenerico.GetAll();
        }

        public async Task<TEntity> GetById(int? id)
        {
            //TODO: Setera datos de auditoria.
            return await _repoGenerico.GetById(id);
        }

        public async Task<bool> Update(TEntity entity)
        {
            //TODO: Setera datos de auditoria.
            return await _repoGenerico.Update(entity);
        }

    }
}