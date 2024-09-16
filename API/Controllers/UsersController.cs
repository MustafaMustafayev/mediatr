using BLL.Mediatr.Users.Commands.CreateUserCommand;
using BLL.Mediatr.Users.Commands.DeleteUserCommand;
using BLL.Mediatr.Users.Commands.UpdateUserCommand;
using BLL.Mediatr.Users.Queries.GetAllUsersQuery;
using BLL.Mediatr.Users.Queries.GetUserByIdQuery;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    private readonly IMediator _mediator;
    public UsersController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var query = new GetAllUsersQuery();
        var response = await _mediator.Send(query);
        return Ok(response);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get([FromRoute]int id)
    {
        var query = new GetUserByIdQuery()
        {
            Id = id
        };

        var response = await _mediator.Send(query);
        return Ok(response);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateUserCommand createUserCommand)
    {
        var response = await _mediator.Send(createUserCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateUserCommand command)
    {
        await _mediator.Send(command);
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] int id)
    {
        var command = new DeleteUserCommand()
        {
            Id = id
        };
        await _mediator.Send(command);
        return Ok();
    }
}
