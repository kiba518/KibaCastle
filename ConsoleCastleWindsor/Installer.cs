using Business;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Castle.Windsor.Installer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCastleWindsor
{
    public class CustomMvcInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                Component.For<IUserService>().ImplementedBy<UserService>()
                );
        }
    }

    public class WindsorInit
    {
        private static WindsorContainer _container;
        public static WindsorContainer GetContainer()
        {
            if (_container == null)
            {
                _container = new WindsorContainer();
                _container.Install(
                    FromAssembly.This()
                    );
            }
            return _container;
        }

        public void CloseContex()
        {
            _container.Dispose();
        }
    }
}
