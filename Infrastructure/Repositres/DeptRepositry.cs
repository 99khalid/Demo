using Demo.Applicatoin.Interfaces;
using Demo.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositres
{
    public class DeptRepositry: Basereposatry<Department>, IDepartment
    {

        public DeptRepositry(DemoDbContext context, IUnitOfWork unitOfWork) : base(context, unitOfWork)
        {
        }

        public async Task<IReadOnlyList<Department>> GetAllDeptAsync()
        {
            List<Department> allDept = new List<Department>();
            allDept = await _context.Departments.Where(i => i.IsDeleted == false).ToListAsync();
            return allDept;
        }

        public async Task<Department> GetDeptAsyncbuid(int id)
        {
            Department Dept = await GetDeptAsyncbuid(id);
            return Dept;
        }
        public async Task<Department> RemoveDeptAsync(int id)
        {
            var userToDelete = await _context.Departments.FindAsync(id);
            if (userToDelete != null)
            {
                userToDelete.IsDeleted = true;
                await UpdateAsync(userToDelete);
                return userToDelete;

            }
            else
            {
                return userToDelete;
            }
        }
    }
}
