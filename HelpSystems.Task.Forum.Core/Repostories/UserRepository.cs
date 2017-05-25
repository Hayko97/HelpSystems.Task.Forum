using HelpSystems.Hayk.Core.Repostories;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelpSystems.Hayk.Core.Interfaces;
using HelpSystems.Task.Forum.Core.DataAccess;
using HelpSystems.Task.Forum.Core.Enums;
using System.Web;

namespace HelpSystems.Task.Forum.Core.Repostories
{
    public class UserRepository : ForumDataEntityRepository<User>
    {
        public DataStatus Register(User user)
        {
            var isAvailable = IsAvailable(x => x.Username == user.Username);
            if (isAvailable == DataStatus.NotAvailable)
            {
                var result = Add(user);

                return result;
            }              
            else
            {
                return DataStatus.IsRegistered;
            }
           
            
        }
        public DataStatus Login(string username, string password)
        {
            var result = IsAvailable(x => x.Username == username && x.Password == password);
            return result;
        }
        public DataStatus CheckAuthRole(string username,string role)
        {
            var result = IsAvailable(x => x.Username == username && x.Roles == role);
            return result;
        }
       
    }
}
