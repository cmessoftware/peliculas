﻿using AutoMapper;
using Microsoft.Extensions.Logging;
using Peliculas.Entidades;
using Peliculas.Servicios.Peliculas;
using Peliculas.UnitOfWorks;
using Peliculas.Web.Dto;

namespace Peliculas.Servicios
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

        public async Task<bool> Create(PeliculaDto peliculaDto)
        {
            if (peliculaDto != null)
            {

                var pelicula = _mapper.Map<Pelicula>(peliculaDto);

                await _unitOfWork.Peliculas.Create(pelicula);

                return _unitOfWork.SaveChanges() > 0;
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

        public async Task<List<PeliculaDto>> GetAll()
        {
            var peliculas = await _unitOfWork.Peliculas.GetAll();

            var peliculasDto = new List<PeliculaDto>();

            foreach (var peli in peliculas)
            {
                var peliculaDto = _mapper.Map<PeliculaDto>(peli);
                peliculasDto.Add(peliculaDto);
            }

            return peliculasDto;
        }

        public async Task<PeliculaDto> GetById(int? id)
        {
            if (id > 0)
            {
                var pelicula = await _unitOfWork.Peliculas.GetById(id);
                if (pelicula != null)
                {
                    var peliculaVM = _mapper.Map<PeliculaDto>(pelicula);
                    return peliculaVM;
                }
            }
            return null;
        }

        public async Task<bool> Update(PeliculaDto peliculaDto)
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

        Task<Pelicula> IServicioGenerico<Pelicula>.GetById(int? id)
        {
            throw new NotImplementedException();
        }

        Task<List<Pelicula>> IServicioGenerico<Pelicula>.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}