  using Entity;
using Infraextrcuture.Repository;
using Infraextructure.Repository;
using IRepository;
namespace Repository
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
