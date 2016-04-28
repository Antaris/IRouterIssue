using Microsoft.AspNet.Mvc.Infrastructure;
using Microsoft.AspNet.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IRouterIssue
{
    public class CustomRouter : IRouter
    {
        public VirtualPathData GetVirtualPath(VirtualPathContext context)
        {
            return null; // NOOP
        }

        public Task RouteAsync(RouteContext context)
        {
            var handler = new MvcRouteHandler();

            context.RouteData.Values.Add("controller", "Home");
            context.RouteData.Values.Add("action", "Index");

            return handler.RouteAsync(context);
        }
    }
}
