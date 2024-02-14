using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Applicatoin.Features.User.Query.Gituserdeatials
{
      public class GitUserDetailsQuery : IRequest<GitUserDetailsviewmodel>
    {
        public int id { get; set; } 
    }
}
