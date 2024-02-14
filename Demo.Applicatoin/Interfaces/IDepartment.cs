using Demo.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Applicatoin.Interfaces
{
    public interface IDepartment : IUserinterface<Department>
    {
        Task<IReadOnlyList<Department>> GetAllDeptAsync();
        Task<Department> GetDeptAsyncbuid(int id);

        Task<Department> RemoveDeptAsync(int id);
    }
}
