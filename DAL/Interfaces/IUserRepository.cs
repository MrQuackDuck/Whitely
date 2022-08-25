using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Whitely.Domain.Models;

namespace Whitely.DAL.Interfaces
{
    public interface IUserRepository : IBaseRepository<User>
    {
        User GetByUsername(string username);
    }
}
