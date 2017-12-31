using System;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Newbe.BeeSite
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            var config = GlobalConfiguration.Configuration;
            config.MapHttpAttributeRoutes();
            config.EnableCors(new DisableCorsAttribute());
            config.EnsureInitialized();
        }
    }
}
