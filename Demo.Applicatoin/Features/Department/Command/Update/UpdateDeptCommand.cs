﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Applicatoin.Features.Department.Command.Update
{
    public class UpdateDeptCommand : IRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
