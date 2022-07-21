using Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfase
{
    public interface IUserDomain
    {
        Task<User> Add(User entity);
        Task<bool> Update(User entity);
        Task<bool> Delete(int id);
        Task<User> Get(int id);
        public Task<IEnumerable<User>> GetAlls();
    }
}
