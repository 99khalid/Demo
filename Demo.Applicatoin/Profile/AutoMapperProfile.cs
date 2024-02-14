using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Demo.Applicatoin.Features.Department.Command.Create;
using Demo.Applicatoin.Features.Department.Command.Update;
using Demo.Applicatoin.Features.Department.Query.GetDeptList;
using Demo.Applicatoin.Features.User.Command.create;
using Demo.Applicatoin.Features.User.Command.update;
using Demo.Applicatoin.Features.User.Query.Gituserdeatials;
using Demo.Applicatoin.Features.User.Query.GitUserLIST;
using Demo.Domain;

namespace Demo.Applicatoin.Profile
{

    public class AutoMapperProfile : AutoMapper.Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, GituserlisVeiwModel>().ReverseMap();
            CreateMap<User, GitUserDetailsviewmodel>().ReverseMap();
            CreateMap<User, CraeteUserCommant>().ReverseMap();
            CreateMap<User, UpdateUserCommand>().ReverseMap();

            CreateMap<Department, GetDeptListViewModel>().ReverseMap();
            CreateMap<Department, GetDeptListViewModel>().ReverseMap();
            CreateMap<Department, CreateDeptCommand>().ReverseMap();
            CreateMap<Department, UpdateDeptCommand>().ReverseMap();

        }
    }
}
