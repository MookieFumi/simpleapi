using System.Net.Http.Formatting;
using System.Web.Http;
using simpleapi.infrastructure;

namespace simpleapi
{
	public static class WebApiConfig
	{
		public static void Register(HttpConfiguration config)
		{
			// Web API configuration and services
			config.Formatters.Clear();
			config.Formatters.Add(new JsonMediaTypeFormatter());
			//config.Formatters.Add(new XmlMediaTypeFormatter());

			// Web API routes
			config.MapHttpAttributeRoutes();

			config.Routes.MapHttpRoute(
				name: "DefaultApi",
				routeTemplate: "api/{controller}/{id}",
				defaults: new { id = RouteParameter.Optional }
			);

			//Handlers
			config.MessageHandlers.Add(new RequireHttpsMessageHandler());
		}
	}


}
