namespace clean_arch.Domain.Events;
public class RestaurantCreatedEvent : BaseEvent
{
    public RestaurantCreatedEvent(Restaurant restaurant)
    {
        Restaurant = restaurant;
    }

    public Restaurant Restaurant { get; }
}
