using Demo.Applicatoin.Features.Department.Command.Create;
using Demo.Applicatoin.Features.Department.Command.Delete;
using Demo.Applicatoin.Features.Department.Command.Update;
using Demo.Applicatoin.Features.Department.Query.GetDeptDetails;
using Demo.Applicatoin.Features.Department.Query.GetDeptList;
using Demo.Applicatoin.Features.User.Command.create;
using Demo.Applicatoin.Features.User.Command.Delete;
using Demo.Applicatoin.Features.User.Command.update;
using Demo.Applicatoin.Features.User.Query.GitUserLIST;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeptControlercs: ControllerBase
    {
        private readonly IMediator _mediator;

        public DeptControlercs(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("all", Name = "GetAllDept")]
        public async Task<ActionResult<List<GetDeptListViewModel>>> GetAllDept()
        {
            var dtos = await _mediator.Send(new GetDeptListQuery());
            return Ok(dtos);
        }

       

        [HttpPost(Name = "CreateDept")]
        public async Task<ActionResult<int>> Create([FromBody] CreateDeptCommand createDeptCommand)
        {
            int id = await _mediator.Send(createDeptCommand);
            return Ok(id);
        }
        [HttpPut(Name = "UpdateDept")]
        public async Task<ActionResult> Update([FromBody] UpdateDeptCommand updateDeptCommand)
        {
            await _mediator.Send(updateDeptCommand);
            return NoContent();
        }

        [HttpPut("{id}/softdelete", Name = "SoftDeleteDept")]
        public async Task<IActionResult> SoftDeleteDept([FromRoute] int id)
        {
            var command = new DeleteDeptCommand { Id = id, IsDeleted = true };
            await _mediator.Send(command);
            return NoContent();
        }


    }
}
