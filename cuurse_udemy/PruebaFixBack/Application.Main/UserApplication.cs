using Application.Dto;
using Application.Interface;
using AutoMapper;
using Common;
using Domain.Interfase;
using Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Main
{
    public class UserApplication : IUserApplication 
    {
        // se crean varibales PRIVATE con las clases que deseamos usar en esta capa 
        private IUserDomain _userDomain;
        private IMapper _mapper;
        //Creamos un constructor en donde inyectamos las interfaces que vamos a utilizar 
        public UserApplication(IUserDomain userDomain, IMapper mapper) 
        {
            //asingamos el valor inyectado a las variables privadas que se declararon anteriormente
            _userDomain = userDomain;
            _mapper = mapper;
        }

        public async Task<Response<UserDto>> Add(UserDto dto)
        {
            //se instancia el objeto de tipo response con el dto en el generico 
            var response = new Response<UserDto>();
            //se mappea el dto a una entidad para utilizarlo en la capa Domain
            var entity = _mapper.Map <User> (dto);
            // como el resultado que nos devuelve el metodo Add is una entidad,
            // lo mappeamos a un dto, seguido lo añadimos al objeto Response en su propiedad data
            response.Data = _mapper.Map<UserDto>(await _userDomain.Add (entity));
            if (response.Data != null) 
            {
                response.IsSuccess = true;
                response.Message = "Successful registration!!!";
            }
            else
            {
                response.IsSuccess = false;
                response.Message = "Error add!!!";
            }
            return response;
        }
        public async Task<Response<bool>> Delete(int id)
        {
            var response = new Response<bool>();
            response.Data = await _userDomain.Delete(id);
            if (response.Data)
            {
                response.IsSuccess = true;
                response.Message = "Successful Deleted!!!";
            }
            else
            {
                response.IsSuccess = false;
                response.Message = "Error Deleted!!!";
            }
            return response;
        }
        public async Task<Response<UserDto>> Get(int id)
        {
            var response = new Response<UserDto>();
            response.Data = _mapper.Map<UserDto>(await _userDomain.Get(id));
            if (response.Data != null)
            {
                response.IsSuccess = true;
                response.Message = "Successful search!!!";
            }
            else
            {
                response.IsSuccess = false;
                response.Message = "Error search!!!";
            }
            return response;
        }

        public async Task<Response<IEnumerable<UserDto>>> GetAll()
        {
            var response = new Response<IEnumerable<UserDto>>();
            response.Data = _mapper.Map<IEnumerable<UserDto>> (await _userDomain.GetAlls());
            if (response.Data != null)
            {
                response.IsSuccess = true;
                response.Message = "Successful search!!!";
            }
            else
            {
                response.IsSuccess = false;
                response.Message = "Error search!!!";
            }
            return response;
        }

        public async Task<Response<bool>> Update(UserDto dto)
        {
            var response = new Response<bool>();
            var entity = _mapper.Map<User>(dto);
            response.Data = await _userDomain.Update(entity);
            if (response.Data)
            {
                response.IsSuccess = true;
                response.Message = "Successful updated!!!";
            }
            else 
            {
                response.IsSuccess = false;
                response.Message = "Error updated!!!";
            }

            return response;
        }
    }
}
