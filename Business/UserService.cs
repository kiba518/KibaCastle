using IBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{ 
    public class UserService : IUserService
    {
        public string Display(string mes)
        {
            return "User say：" + mes;
        }
    }
}
