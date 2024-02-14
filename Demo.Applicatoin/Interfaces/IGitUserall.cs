using Demo.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Applicatoin.Interfaces
{
    public interface IGitUserall :IUserinterface<User>
    {
        Task<IReadOnlyList<User>> GetAlluserAsync();
        Task<User> GetuserAsyncbuid(int id);

        Task<User> RemoveAsync(int id);

    }
}
