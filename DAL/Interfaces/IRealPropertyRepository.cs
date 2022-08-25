using Whitely.DAL.Repositories;
using Whitely.Domain.Models;

namespace Whitely.DAL.Interfaces
{
    public interface IRealPropertyRepository : IBaseRepository<RealProperty>
    {
        RealProperty GetByName(string name);
        bool DeleteImage(int id);
    }
}