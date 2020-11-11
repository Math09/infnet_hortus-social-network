using hortus.Services;
using Microsoft.Owin.Security.OAuth;
using System.Security.Claims;
using System.Threading.Tasks;

namespace hortus.Providers
{
    public class ActiveDirectoryOAuthProvider : OAuthAuthorizationServerProvider
    {
        public override async Task ValidateClientAuthentication( OAuthValidateClientAuthenticationContext context )
        {
            context.Validated();
        }

        public override async Task GrantResourceOwnerCredentials( OAuthGrantResourceOwnerCredentialsContext context )
        {
            bool login = AuthService.Login( context.UserName, context.Password );

            if( login )
            {
                var identity = new ClaimsIdentity( context.Options.AuthenticationType );
                
                identity.AddClaim( new Claim( "sub", context.UserName ) );
                identity.AddClaim( new Claim( "role", "user" ) );

                context.Validated( identity );
            }
            else
            {
                context.SetError( "Acesso inválido: ", "Credenciais não conferem." );
                return;
            }
        }
    }
}