using clean_arch.Application.TodoItems.EventHandlers;
using clean_arch.Domain.Events;
using Microsoft.Extensions.Logging;

namespace clean_arch.Application.Restaurants.EventHandlers;
public class RestaurantCreatedEventHandler
{
    private readonly ILogger<RestaurantCreatedEventHandler> _logger;

    public RestaurantCreatedEventHandler(ILogger<RestaurantCreatedEventHandler> logger)
        => _logger = logger;

    public Task Handle(RestaurantCreatedEventHandler notification, CancellationToken cancellationToken)
    {
        _logger.LogInformation("clean_arch Domain Event: {DomainEvent}", notification.GetType().Name);

        return Task.CompletedTask;
    }
}
