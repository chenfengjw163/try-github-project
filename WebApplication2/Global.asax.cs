using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace WebApplication2
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        public static List<string> logs = new List<string>();
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Application_BeginRequest()
        {
            logs.Add("BeginRequest:" + DateTime.Now.ToString("HH:mm:ss fff"));
        }
        protected void Application_AuthenticateRequest()
        {
            logs.Add("AuthenticateRequest:" + DateTime.Now.ToString("HH:mm:ss fff"));
        }
        protected void Application_AuthorizeRequest()
        {
            logs.Add("AuthorizeRequest:" + DateTime.Now.ToString("HH:mm:ss fff"));
        }
        protected void Application_ResolveRequestCache()
        {
            logs.Add("ResolveRequestCache:" + DateTime.Now.ToString("HH:mm:ss fff"));
        }
        protected void Application_PostMapRequestHandler()
        {
            logs.Add("PostMapRequestHandler:" + DateTime.Now.ToString("HH:mm:ss fff"));
        }
        protected void Application_AcquireRequestState()
        {
            logs.Add("AcquireRequestState:" + DateTime.Now.ToString("HH:mm:ss fff"));
        }
        protected void Application_PreRequestHandlerExecute()
        {
            logs.Add("PreRequestHandlerExecute:" + DateTime.Now.ToString("HH:mm:ss fff"));
        }
        protected void Application_ReleaseRequestState()
        {
            logs.Add("ReleaseRequestState:" + DateTime.Now.ToString("HH:mm:ss fff"));
        }
        protected void Application_UpdateRequestCache()
        {
            logs.Add("UpdateRequestCache:" + DateTime.Now.ToString("HH:mm:ss fff"));
        }
        protected void Application_LogRequest()
        {
            logs.Add("LogRequest:" + DateTime.Now.ToString("HH:mm:ss fff"));
        }
        protected void Application_EndRequest()
        {
            logs.Add("EndRequest:" + DateTime.Now.ToString("HH:mm:ss fff"));
            HttpContext.Current.Response.Write(String.Join("<br/>", logs));
            logs.Clear();
        }
    }
}
