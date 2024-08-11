using Core.Persistence.Repositories;
using Domain.Entities;

namespace Application.Repositories
{
    public interface ITitleRepository : IAsyncRepository<Title, short>, IRepository<Title, short>
    {
    }
}
