﻿using Peliculas.Entidades;
using Peliculas.UnitOfWorks;

namespace Peliculas.Servicios
{
    public class ServicioActores : IServicioActores
    {
        public IUnitOfWork _unitOfWork;

        public ServicioActores(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> Create(Actor actor)
        {
            if (actor != null)
            {
                //actor.FechaCreacion = DateTime.Now();
                //actor.FechaActualizacion = DateTime.Now();
                //actor.UsuarioCreacion = "Usuario";
                //actor.UsuaraioActualizacion = "Usuario1";


                await _unitOfWork.Actores.Create(actor);
                var result = _unitOfWork.SaveChanges();

                //Aca actualizar datos de auditoria

                return result > 0;
            }
            return false;
        }

        public async Task<bool> Delete(int? id)

        {
            if (id > 0)
            {
                //actor.FechaCreacion = DateTime.Now();
                //actor.FechaActualizacion = DateTime.Now();
                //actor.UsuarioCreacion = "Usuario";
                //actor.UsuaraioActualizacion = "Usuario1";

                return await _unitOfWork.Actores.Delete(id);
            }
            return false;
        }

        public Task<bool> Delete(Actor actor)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteConfirmed(int? id)
        {
            if (id != null)
            {
                return await _unitOfWork.Actores.DeleteConfirmed(id);
            }

            return false;
        }

        public async Task<List<Actor>> GetAll()
        {
            var actores = await _unitOfWork.Actores.GetAll();
            return actores;
        }

        public async Task<Actor> GetById(int? id)
        {
            if (id > 0)
            {
                var actor = await _unitOfWork.Actores.GetById(id);
                if (actor != null)
                {
                    return actor;
                }
            }
            return null;
        }

        public async Task<bool> Update(Actor actor)
        {
            if (actor != null)
            {
                var comentarioDB = await _unitOfWork.Actores.GetById(actor.Id);
                if (comentarioDB != null)
                {
                    //Aca actualizar datos de auditoria
                    //actor.FechaCreacion = DateTime.Now();
                    //actor.FechaActualizacion = DateTime.Now();
                    //actor.UsuarioCreacion = "Usuario";
                    //actor.UsuaraioActualizacion = "Usuario1";

                    await _unitOfWork.Actores.Update(comentarioDB);

                    var result = _unitOfWork.SaveChanges();

                    return result > 0;
                }
            }
            return false;
        }
    }
}