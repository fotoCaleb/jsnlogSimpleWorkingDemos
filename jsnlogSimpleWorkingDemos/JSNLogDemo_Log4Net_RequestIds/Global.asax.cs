using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;


namespace JSNLogDemo_Log4Net_RequestIds
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            RouteConfig.RegisterRoutes(RouteTable.Routes);
			
			
log4net.Config.XmlConfigurator.Configure();

        }

        protected void Application_BeginRequest()
        {
			
			
	log4net.GlobalContext.Properties["requestId"] = 
        JSNLog.JavascriptLogging.RequestId();
    log4net.Config.XmlConfigurator.Configure();
	
        }
    }
}




