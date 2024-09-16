using BLL.Mediatr.Roles.Commands.CreateRoleCommand;
using BLL.Mediatr.Roles.Commands.DeleteRoleCommand;
using BLL.Mediatr.Roles.Commands.UpdateRoleCommand;
using BLL.Mediatr.Roles.Queries.GetAllRolesQuery;
using BLL.Mediatr.Roles.Queries.GetRoleByIdQuery;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class RolesController : ControllerBase
{
    private readonly IMediator _mediator;
    public RolesController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        GetAllRolesQuery query = new();
        var response = await _mediator.Send(query);
        return Ok(response);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get([FromRoute] int id)
    {
        GetRoleByIdQuery query = new()
        {
            Id = id
        };

        var response = await _mediator.Send(query);
        return Ok(response);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateRoleCommand command)
    {
        await _mediator.Send(command);
        return Ok();
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateRoleCommand command)
    {
        await _mediator.Send(command);
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] int id)
    {
        var command = new DeleteRoleCommand()
        {
            Id = id
        };
        await _mediator.Send(command);
        return Ok();
    }
}
