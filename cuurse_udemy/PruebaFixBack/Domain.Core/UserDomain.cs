using Domain.Interfase;
using Entity;
using IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Core
{
    public class UserDomain : IUserDomain
    {
        private IUserRepository _userRepository;
        public UserDomain(IUserRepository userRepository) 
        {
            _userRepository = userRepository;
        }
        public async Task<User> Add(User entity)
        {
            return await _userRepository.AddAsync(entity);
        }

        public async Task<bool> Delete(int id)
        {
            try
            {
                var entity = Get(id).Result;
                if (entity != null)
                {
                    await _userRepository.DeleteAsync(entity);
                    return true;
                }
                else 
                {
                    return false;
                }
            }
            catch (Exception )
            {
                return false;
            }
        }

        public async Task<User> Get(int id)
        {
            return await _userRepository.GetByIdAsync(id);

        }

        public async Task<IEnumerable<User>> GetAlls()
        {
            return await _userRepository.GetAllAsync();
        }

        public async Task<bool> Update(User entity)
        {
            try
            {
                 await _userRepository.UpdateAsync(entity);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
