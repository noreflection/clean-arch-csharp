using AutoMapper;
using clean_arch.Application.Common.Exceptions;
using clean_arch.Application.Common.Interfaces;
using clean_arch.Domain.Entities;
using MediatR;

namespace clean_arch.Application.Restaurants.Commands.UpdateRestaurant;
public class UpdateRestaurantCommand : IRequest
{
    public int Id { get; set; }
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

public class UpdateRestaurantCommandHandler : IRequestHandler<UpdateRestaurantCommand>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public UpdateRestaurantCommandHandler(IApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<Unit> Handle(UpdateRestaurantCommand request, CancellationToken cancellationToken)
    {
        var entity = await _context.Restaurants
            .FindAsync(new object[] { request.Id }, cancellationToken);

        if (entity == null)
        {
            throw new NotFoundException(nameof(Restaurant), request.Id);
        }

        entity.Name = request.Name;
        entity.Phone = request.Phone;
        entity.Email = request.Email;
        entity.Logo = request.Logo;
        entity.Address = request.Address;
        entity.Latitude = request.Latitude;
        entity.Longitude = request.Longitude;
        entity.Commission = request.Commission;
        entity.CommissionType = request.CommissionType;
        entity.Rating = request.Rating;
        entity.OpeningTime = request.OpeningTime;
        entity.ClosingTime = request.ClosingTime;
        entity.OffDay = request.OffDay;
        entity.DeliveryCharge = request.DeliveryCharge;
        entity.Capacity = request.Capacity;
        entity.OrderCount = request.OrderCount;
        entity.VendorId = request.VendorId;
        entity.CategoryId = request.CategoryId;
        entity.ZoneId= request.ZoneId;
        entity.SurgeZoneId = request.SurgeZoneId;
        entity.IsActive= request.IsActive;
        entity.IsUpfrontPayment = request.IsUpfrontPayment;
        entity.IsDeleted = request.IsDeleted;

        await _context.SaveChangesAsync(cancellationToken);

        return Unit.Value;
    }
}