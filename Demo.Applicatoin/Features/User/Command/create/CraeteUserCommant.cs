using Demo.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Applicatoin.Features.User.Command.create
{
    public class CraeteUserCommant : IRequest<int>
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int DepartmentId { get; set; }
    }
}
