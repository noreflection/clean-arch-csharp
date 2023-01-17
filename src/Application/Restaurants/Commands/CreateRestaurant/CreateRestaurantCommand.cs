using System.ComponentModel.DataAnnotations;
using clean_arch.Application.Common.Interfaces;
using clean_arch.Application.TodoItems.Commands.CreateTodoItem;
using clean_arch.Domain.Entities;
using clean_arch.Domain.Events;
using MediatR;

namespace clean_arch.Application.Restaurants.Commands.CreateRestaurant;

public record CreateRestaurantCommand : IRequest<int>
{
    public string Name { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Logo { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public double Commission { get; set; }
    public double CommissionType { get; set; }
    public DateTime OpeningTime { get; set; }
    public DateTime ClosingTime { get; set; }
    public double Rating { get; set; }
    public string OffDay { get; set; } = string.Empty;
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

public class CreateRestaurantCommandHandler : IRequestHandler<CreateRestaurantCommand, int>
{
    private readonly IApplicationDbContext _context;

    public CreateRestaurantCommandHandler(IApplicationDbContext context)
        => _context = context;

    public async Task<int> Handle(CreateRestaurantCommand request, CancellationToken cancellationToken)
    {
        var entity = new Restaurant
        {
            Name = request.Name,
            Phone = request.Phone,
            Email = request.Email,
            Logo = request.Logo,
            Address= request.Address,
            Latitude= request.Latitude,
            Longitude= request.Longitude,
            Commission = request.Commission,
            CommissionType = request.CommissionType,
            OpeningTime = request.OpeningTime,
            ClosingTime = request.ClosingTime,
            Rating = request.Rating,
            OffDay = request.OffDay,
            DeliveryCharge = request.DeliveryCharge,
            Capacity = request.Capacity,
            OrderCount = request.OrderCount,
            VendorId = request.VendorId,
            CategoryId = request.CategoryId,
            ZoneId = request.ZoneId,
            SurgeZoneId = request.SurgeZoneId,
            IsActive = request.IsActive,
            IsUpfrontPayment = request.IsUpfrontPayment,
            IsDeleted = request.IsDeleted
        };

        entity.AddDomainEvent(new RestaurantCreatedEvent(entity));

        _context.Restaurants.Add(entity);

        await _context.SaveChangesAsync(cancellationToken);

        return entity.Id;
    }
}
