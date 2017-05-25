using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelpSystems.Task.Forum.Infrastructure
{
    public class ForumDR : IDependencyResolver
    {
        private IUnityContainer container;
        public ForumDR(IUnityContainer _container)
        {
            container = _container;
        }
        public object GetService(Type serviceType)
        {
            try
            {
                return container.Resolve(serviceType);
            }
            catch(Exception e)
            {
                return null;
            }
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            try
            {
                return container.ResolveAll(serviceType);
            }
            catch (Exception e)
            {
                return null;
            }

        }
    }
}