using Core.Persistence.Repositories;
using Domain.Entities;

namespace Application.Services.Repositories;

public interface IBrandReposiory : IAsyncRepository<Brand,Guid>, IRepository<Brand,Guid>
{

}
