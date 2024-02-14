using MediatR;


namespace Demo.Applicatoin.Features.Department.Command.Create
{
    public class CreateDeptCommand : IRequest<int>
    {
        public string Name { get; set; }
    }
}
