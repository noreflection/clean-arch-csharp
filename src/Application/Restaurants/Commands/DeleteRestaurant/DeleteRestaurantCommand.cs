using clean_arch.Application.Common.Exceptions;
using clean_arch.Application.Common.Interfaces;
using clean_arch.Domain.Entities;
using clean_arch.Domain.Events;
using MediatR;

namespace clean_arch.Application.Restaurants.Commands.DeleteRestaurant;
public record DeleteRestaurantCommand (int id) : IRequest;

public class DeleteRestaurantCommandHandler : IRequestHandler<DeleteRestaurantCommand>
{
    private readonly IApplicationDbContext _context;

    public DeleteRestaurantCommandHandler(IApplicationDbContext context)
        => _context = context;

    public async Task<Unit> Handle(DeleteRestaurantCommand request, CancellationToken cancellationToken)
    {
        var entity = await _context.Restaurants.FindAsync(new object[] { request.id }, cancellationToken);

        if (entity == null)
        {
            throw new NotFoundException(nameof(TodoItem), request.id);
        }

        _context.Restaurants.Remove(entity);

        entity.AddDomainEvent(new RestaurantDeletedEvent(entity));

        await _context.SaveChangesAsync(cancellationToken);

        return Unit.Value;
    }
}