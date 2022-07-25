using MoveisSite.Models;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace MoveisSite.Data.Services
{
    public interface IActorsService
    {
        Task<IEnumerable<Actor>> GetAllAsync();
        Task<Actor> GetByIdAsync(int id);
        Task AddAsync(Actor actor);
        Task<Actor> UpdateAsync(int id, Actor newActor);
        void Delete(int id);
    }
}
