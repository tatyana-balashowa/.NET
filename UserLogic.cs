using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Users.DAL;
using Users.Entities;
namespace Users.BLL
{
    public class UserLogic : IUserLogic
    {
        private IUserDao userDao;
        public UserLogic()
        {
            userDao = new UserDaoDB();
        }
        public int? Add(User user)
        {
            return userDao.Add(user);
        }
        public IEnumerable <User> GetUsers()
        {
            return userDao.GetUsers();
        }
        public void Remove (int index)
        {
            userDao.Remove(index);
        }

    }
}
