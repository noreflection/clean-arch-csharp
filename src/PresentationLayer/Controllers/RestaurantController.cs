using clean_arch.Application.Restaurants.Commands.CreateRestaurant;
using clean_arch.Application.Restaurants.Commands.DeleteRestaurant;
using clean_arch.Application.Restaurants.Commands.UpdateRestaurant;
using clean_arch.Application.Restaurants.Queries.GetRestaurants;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers;

//[Authorize]
public class RestaurantController : ApiControllerBase
{
    [HttpGet("{id}")]
    public async Task<ActionResult<RestaurantDto>> GetById(int id)
        => await Mediator.Send(new GetRestaurantByIdQuery(id));

    [HttpGet("all")]
    public async Task<ActionResult<List<RestaurantDto>>> GetAll(
        [FromQuery] GetRestaurantsQuery query)
        => await Mediator.Send(query);

    [HttpPost("create")]
    public async Task<ActionResult<int>> Create(CreateRestaurantCommand command)
        => await Mediator.Send(command);

    [HttpPut("update/{id}")]
    public async Task<ActionResult<int>> Update(int id, UpdateRestaurantCommand command)
    {
        if (id != command.Id)
        {
            return BadRequest();
        }

        await Mediator.Send(command);

        return NoContent();
    }

    [HttpDelete("delete/{id}")]
    public async Task<ActionResult> Delete(int id)
    {
        await Mediator.Send(new DeleteRestaurantCommand(id));
        return NoContent();
    }
}
