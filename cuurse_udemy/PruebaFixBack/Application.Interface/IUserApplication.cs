using Application.Dto;
using Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interface
{
    public interface IUserApplication
    {

        Task<Response<UserDto >> Add(UserDto dto);
        Task<Response<bool>> Update(UserDto dto);
        Task<Response<bool>> Delete(int id);
        Task<Response<UserDto>> Get(int id);
        Task<Response<IEnumerable<UserDto>>> GetAll();
    }
}
