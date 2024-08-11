using Core.Persistence.Paging;
using Core.Persistence.Repositories;
using Domain.Entities;

namespace Application.Repositories
{
    public interface IFeedbackRepository : IAsyncRepository<Feedback, int>, IRepository<Feedback, int>
    {
        Task<IPaginate<Feedback>> GetFeedbacksWithDynamicSearch(int pageIndex, int pageSize, string? orderDate, int? doctorId, int? branchId, bool enableTracking = false);
    }
}
