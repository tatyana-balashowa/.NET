using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Users.Entities;
namespace Users.BLL
{
    public interface IUserLogic
    {
        IEnumerable<User> GetUsers();
        int? Add(User user);
        void Remove(int index);
    }
}
