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
    public class userRepositry:Basereposatry<User>,IGitUserall
    {
        public userRepositry(DemoDbContext context, IUnitOfWork unitOfWork) : base(context, unitOfWork)
        {
        }
        public async Task<IReadOnlyList<User>> GetAlluserAsync()
        {
            List<User> allUsers = new List<User>();
            allUsers = await _context.Users.Where(i=>i.IsDeleted==false).ToListAsync();
            return allUsers;
        }

        public async Task<User> GetuserAsyncbuid(int id)
        {
            User user = await GetByIdAsync(id);
            return user;
        }
        public async Task<User> RemoveAsync(int id)
        {
            var userToDelete = await _context.Users.FindAsync(id);
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
