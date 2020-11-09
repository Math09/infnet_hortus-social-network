using System;
using System.Threading.Tasks;
using System.Web.Http;
using hortus.Providers;
using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Microsoft.Owin.Security.OAuth;
using Owin;

[assembly: OwinStartup( typeof( hortus.Startup ) )]
namespace hortus
{
    public class Startup
    {
        public void Configuration( IAppBuilder app ) 
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=316888
            var config = new HttpConfiguration();

            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute( 
                
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }

            );

            app.UseCors( CorsOptions.AllowAll );

            GeneratingAccessToken( app );

            app.UseWebApi( config );
        }

        public void GeneratingAccessToken( IAppBuilder app )
        {
            app.UseOAuthBearerAuthentication( new OAuthBearerAuthenticationOptions() );

            app.UseOAuthAuthorizationServer( new OAuthAuthorizationServerOptions() {

                TokenEndpointPath = new PathString( "/token" ),
                Provider = new ActiveDirectoryOAuthProvider(),
                AccessTokenExpireTimeSpan = TimeSpan.FromDays( 1 ),
                AllowInsecureHttp = true

            } );
        }
    }
}
