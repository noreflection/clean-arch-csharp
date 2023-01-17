namespace clean_arch.Domain.Events;
public class RestaurantDeletedEvent : BaseEvent
{
    public RestaurantDeletedEvent(Restaurant restaurant)
    {
        Restaurant = restaurant;
    }

    public Restaurant Restaurant { get; }
}
