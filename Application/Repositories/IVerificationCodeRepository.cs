using Core.Persistence.Repositories;
using Domain.Entities;

namespace Application.Repositories
{
    public interface IVerificationCodeRepository : IAsyncRepository<VerificationCode, int>,
        IRepository<VerificationCode, int> 
        
    {
    }
}
