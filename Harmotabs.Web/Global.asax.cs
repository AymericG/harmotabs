using System.Configuration;
using System.Data.Entity;
using System.Reflection;
using System.Web.Mvc;
using System.Web.Routing;
using DbUp;
using Harmotabs.Web.Models;

namespace Harmotabs.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            Database.SetInitializer<HarmotabsContext>(null);
            var upgrader = DeployChanges.To.SqlDatabase(ConfigurationManager.ConnectionStrings["HarmotabsContext"].ConnectionString).WithScriptsEmbeddedInAssembly(Assembly.GetExecutingAssembly()).Build();
            var result = upgrader.PerformUpgrade();
            
        }
    }
}
