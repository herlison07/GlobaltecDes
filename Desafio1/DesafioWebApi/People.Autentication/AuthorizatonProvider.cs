using Microsoft.Owin.Security.OAuth;
using People.Autentication.DataContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace People.Autentication
{
    public class AuthorizatonProvider : OAuthAuthorizationServerProvider
    {
        private PeopleDataContext db = new PeopleDataContext();

        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            context.Validated();
        }
        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            context.OwinContext.Response.Headers.Add("Access-Control-Allow-Oringi", new[] {"*"});
            try
            {
                var user = context.UserName;
                var pass = context.Password;

                List<Models.People> List = db.People.ToList<Models.People>();

                if(Models.People.GetPeopleAcess(List, user, pass)==null)
                {
                    context.SetError("Erro de Autenticação", "Usuário ou Senha Inválidos");
                    return;
                }

                var identity = new ClaimsIdentity(context.Options.AuthenticationType);
                identity.AddClaim(new Claim(ClaimTypes.Name, user));

                var role = new List<string>();
                role.Add("Usuário");

                GenericPrincipal Principal = new GenericPrincipal(identity, role.ToArray());
                Thread.CurrentPrincipal = Principal;

                context.Validated(identity);

            }
            catch (Exception)
            {
                context.SetError("Erro de Autenticação", "Usuário ou Senha Inválidos");
            }
        }
    }
}