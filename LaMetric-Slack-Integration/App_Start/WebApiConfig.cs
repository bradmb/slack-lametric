using System.Web.Http;

namespace LaMetric_Slack_Integration
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "{controller}/{id}",
                defaults: new { controller = "Slack", id = RouteParameter.Optional }
            );
        }
    }
}
