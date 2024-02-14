using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Applicatoin.Features.Department.Command.Delete
{
    public class DeleteDeptCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
    }
}
