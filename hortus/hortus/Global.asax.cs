using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace hortus
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure( WebApiConfig.Register );
        }

        protected void Application_BeginRequest( object sender, EventArgs e )
        {
            var origin = Context.Request.Headers["Origin"];

            if( string.IsNullOrWhiteSpace( origin ) )
            {
                origin = "*";
            }

            Context.Response.AddHeader( "Access-Control-Allow-Origin", origin );
            Context.Response.AddHeader( "Access-Control-Allow-Credentials", "true" );
            Context.Response.AddHeader( "Access-Control-Allow-Methods", "GET, HEAD, OPTIONS. POST, PUT, DELETE" );
            Context.Response.AddHeader( "Access-Control-Allow-Headers", "Access-Control-Allow-Headers, Origin, Accept, X-Requested-With, Content-Type, Access-Control-Request-Method, Access-Control-Allow-Credentials, Authorization" );

            if( Context.Request.HttpMethod != "OPTIONS" )
            {
                return;
            }

            Context.Response.End();
        }
    }
}
