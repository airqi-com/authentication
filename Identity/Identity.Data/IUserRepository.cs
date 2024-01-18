using Identity.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identity.Data
{
    public interface IUserRepository : IRepository<User>
    {
        // Additional methods specific to User entities
    }

}
