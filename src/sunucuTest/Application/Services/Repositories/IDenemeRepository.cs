using Domain.Entities;
using NArchitecture.Core.Persistence.Repositories;

namespace Application.Services.Repositories;

public interface IDenemeRepository : IAsyncRepository<Deneme, int>, IRepository<Deneme, int>
{
}