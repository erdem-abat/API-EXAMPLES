using Dispose.Data.Abstract;
using Dispose.Models;

namespace dispose.Data.Abstract
{
    public interface IUserRepository : IGenericRepository<User>
    {
        void Dispose();
    }
}
