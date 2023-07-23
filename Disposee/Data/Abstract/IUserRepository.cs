using dispose.Models;

namespace dispose.Data.Abstract
{
    public interface IUserRepository : IGenericRepository<User>
    {
        void Dispose();
    }
}
