using System.Web.Http;

namespace WebApplication;

public class MvcApplication : System.Web.HttpApplication
{
    protected void Application_Start()
    {
        // Pass a delegate to the Configure method.
        GlobalConfiguration.Configure(WebApiConfig.Register);
    }
}