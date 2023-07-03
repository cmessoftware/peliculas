using AutoMapper;
using Movies.WebApi.Dto.Account;
using Movies.WebApi.Entities;

namespace Movies.WebApi.Mappers
{
    public class RoleMapper : IRoleMapper
    {
        private readonly IMapper _mapper;

        public RoleMapper(IMapper mapper)
        {
            _mapper = mapper;
        }

        public List<RoleDto>? Map(List<Role> roles) 
        {
            List<RoleDto> rolesDto = new List<RoleDto>();

            foreach (var r in roles)
            {
                var role = _mapper.Map<RoleDto>(r);
                rolesDto.Add(role);
            }

            return rolesDto;
        
        }
    }
}