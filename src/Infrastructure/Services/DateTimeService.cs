using clean_arch.Application.Common.Interfaces;

namespace clean_arch.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.UtcNow;
}
