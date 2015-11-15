using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Runtime.Serialization;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Xml.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using WebApi.Converter;
using WebApi.Models;

namespace WebApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            ResultFommatConfig(GlobalConfiguration.Configuration);
        }

        private void ResultFommatConfig(HttpConfiguration config)
        {
            var jsonFormatter = config.Formatters.JsonFormatter;
            var xmlFormatter = config.Formatters.XmlFormatter;

            //jsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

            //use customer converter for PagedList<T>
            jsonFormatter.SerializerSettings.Converters.Add(new PagedListConverter());
            jsonFormatter.SerializerSettings.DateTimeZoneHandling = DateTimeZoneHandling.Local;
            //Microsoft JSON date format ("/Date(ticks)/")
            jsonFormatter.SerializerSettings.DateFormatHandling = DateFormatHandling.MicrosoftDateFormat;
            //ISO 8601 date format ("2015-03-05T05:40Z")  2015-03-05Thh:mm:ss.ffffffZ
            jsonFormatter.SerializerSettings.DateFormatHandling = DateFormatHandling.IsoDateFormat;

            //config.Formatters.Remove(jsonFormatter);

            //config.Formatters.XmlFormatter.UseXmlSerializer = true;
            
            //xmlFormatter.SetSerializer(typeof(PagedList<Product>), new PagedListXmlSerializer());

            //xmlFormatter.SetSerializer(typeof(PagedList<Product>), 
            //    new DataContractSerializer(typeof(PagedList<Product>), new List<Type>() { typeof(PagedList<Product>) }, int.MaxValue, 
            //    false, false, null));

            DefaultContentNegotiator negotiator = new DefaultContentNegotiator(true);
            config.Services.Replace(typeof(IContentNegotiator), negotiator);
        }
    }
}
