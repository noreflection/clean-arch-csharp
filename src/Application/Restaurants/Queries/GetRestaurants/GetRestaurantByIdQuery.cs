using AutoMapper;
using clean_arch.Application.Common.Interfaces;
using MediatR;

namespace clean_arch.Application.Restaurants.Queries.GetRestaurants;
public record GetRestaurantByIdQuery (int id) : IRequest<RestaurantDto>;

public class GetRestaurantByIdQueryHandler : IRequestHandler<GetRestaurantByIdQuery, RestaurantDto>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public GetRestaurantByIdQueryHandler(IApplicationDbContext context, IMapper mapper)
        => (_context, _mapper) = (context, mapper);

    public async Task<RestaurantDto> Handle(GetRestaurantByIdQuery request,
        CancellationToken cancellationToken)
        => _mapper.Map<RestaurantDto>(await _context.Restaurants.FindAsync(new object?[] { request.id, cancellationToken }, cancellationToken: cancellationToken));
}
