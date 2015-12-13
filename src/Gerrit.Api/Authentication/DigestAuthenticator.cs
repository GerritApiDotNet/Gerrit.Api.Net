using System.Net;
using RestSharp;
using RestSharp.Authenticators;

namespace Gerrit.Api.Authentication
{
    internal class DigestAuthenticator : IAuthenticator
    {
        private readonly string user;
        private readonly string password;

        public DigestAuthenticator(string user, string password)
        {
            this.user = user;
            this.password = password;
        }

        public void Authenticate(IRestClient restClient, IRestRequest restRequest)
        {
            restRequest.Credentials = new NetworkCredential(user, password);
        }
    }
}
