using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Pizza_Relationship_Database_5_5.Models;
using System.Data.Entity;

namespace Pizza_Relationship_Database_5_5
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Database.SetInitializer<Pizza_Relationship_Database_5_5Context>(new DropCreateDatabaseIfModelChanges<Pizza_Relationship_Database_5_5Context>());
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
