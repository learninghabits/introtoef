using System.Web.Http;

namespace intro_to_ef
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "topicsAPI",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "root",
                routeTemplate: "",
                defaults: new {controller = "Root",  id = RouteParameter.Optional }
            );
        }
    }
}
