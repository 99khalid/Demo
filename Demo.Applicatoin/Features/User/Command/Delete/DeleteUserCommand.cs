using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Applicatoin.Features.User.Command.Delete
{
    public class DeleteUserCommand : IRequest<Unit>
    {
        public int UserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
