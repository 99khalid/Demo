using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Applicatoin.Features.Department.Query.GetDeptDetails
{
    public class GetDeptDetailsViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Domain.User> Users { get; set; }
    }
}
