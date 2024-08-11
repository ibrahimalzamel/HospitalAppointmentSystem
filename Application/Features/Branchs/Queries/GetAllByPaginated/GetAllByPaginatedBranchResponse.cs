using Core.Persistence.Paging;
using Domain.Dtos;

namespace Application.Features.Branchs.Queries.GetAllByPaginated
{
    public class GetAllByPaginatedBranchResponse
    {
        public IPaginate<BranchDto>? Branches { get; set; }
    }
}
