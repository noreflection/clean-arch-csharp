using clean_arch.Application.Common.Mappings;
using clean_arch.Domain.Entities;

namespace clean_arch.Application.Restaurants.Queries.GetRestaurants;
public class RestaurantDto : IMapFrom<Restaurant>
{
    public string Name { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string Logo { get; set; }
    public string Address { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public double Commission { get; set; }
    public double CommissionType { get; set; }
    public DateTime OpeningTime { get; set; }
    public DateTime ClosingTime { get; set; }
    public double Rating { get; set; }
    public string OffDay { get; set; }
    public double DeliveryCharge { get; set; }
    public int Capacity { get; set; }
    public int OrderCount { get; set; }
    public Guid VendorId { get; set; }
    public Guid CategoryId { get; set; }
    public Guid ZoneId { get; set; }
    public Guid SurgeZoneId { get; set; }
    public bool IsActive { get; set; }
    public bool IsUpfrontPayment { get; set; }
    public bool IsDeleted { get; set; }
}
