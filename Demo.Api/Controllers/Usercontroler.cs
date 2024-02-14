using Demo.Applicatoin.Features.User.Command.create;
using Demo.Applicatoin.Features.User.Command.Delete;
using Demo.Applicatoin.Features.User.Command.update;
using Demo.Applicatoin.Features.User.Query.Gituserdeatials;
using Demo.Applicatoin.Features.User.Query.GitUserLIST;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Demo.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("all", Name = "GetAllUsers")]
        public async Task<ActionResult<List<GituserlisVeiwModel>>> GetAllUsers()
        {
            var dtos = await _mediator.Send(new GitUserListQuery());
            return Ok(dtos);
        }

        [HttpGet("{id}", Name = "GetUserById")]
        public async Task<ActionResult<GitUserDetailsviewmodel>> GetUserById(int id)
        {
            var getEventDetailQuery = new GitUserDetailsQuery { id = id };
            return Ok(await _mediator.Send(getEventDetailQuery));
        }

        [HttpPost(Name = "CreateUser")]
        public async Task<ActionResult<int>> Create([FromBody] CraeteUserCommant createUserCommand)
        {
            int id = await _mediator.Send(createUserCommand);
            return Ok(id);
        }

        [HttpPut(Name = "UpdateUser")]
        public async Task<ActionResult> Update([FromBody] UpdateUserCommand updateUserCommand)
        {
            await _mediator.Send(updateUserCommand);
            return NoContent();
        }

        [HttpPut("{id}/softdelete", Name = "SoftDeleteUser")]
        public async Task<IActionResult> SoftDeleteUser([FromRoute] int id)
        {
            var command = new DeleteUserCommand { UserId = id, IsDeleted = true };
            await _mediator.Send(command);
            return NoContent();
        }
    }
}
