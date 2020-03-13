using IBusiness;
using Castle.MicroKernel;
using Castle.Windsor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IOC;

namespace ConsoleCastleWindsor
{
    class Program
    {
        static void Main(string[] args)
        {
            IUserService _userService;
            WindsorContainer container = WindsorInit.GetContainer();
            _userService = container.Resolve<IUserService>(new Arguments());
            var Name = _userService.Display("I am coming by Windsor");
        }


    }
}
