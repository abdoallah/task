using New_folder.Application.Common.Interfaces;

namespace New_folder.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
