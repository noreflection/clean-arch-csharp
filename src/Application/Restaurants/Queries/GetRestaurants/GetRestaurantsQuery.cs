using AutoMapper;
using AutoMapper.QueryableExtensions;
using clean_arch.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace clean_arch.Application.Restaurants.Queries.GetRestaurants;
public record GetRestaurantsQuery : IRequest<List<RestaurantDto>>;

public class GetRestaurantsQueryHandler : IRequestHandler<GetRestaurantsQuery, List<RestaurantDto>>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public GetRestaurantsQueryHandler(IApplicationDbContext context, IMapper mapper)
        => (_context, _mapper) = (context, mapper);

    public async Task<List<RestaurantDto>> Handle(GetRestaurantsQuery request,
        CancellationToken cancellationToken)
        => await _context.Restaurants
            .OrderBy(x => x.Name)
            .ProjectTo<RestaurantDto>(_mapper.ConfigurationProvider)
            .ToListAsync();
}