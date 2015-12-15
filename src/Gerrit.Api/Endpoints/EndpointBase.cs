using Gerrit.Api.Authentication;
using Gerrit.Api.Common.Configuration;
using Newtonsoft.Json;
using RestSharp;

namespace Gerrit.Api.Endpoints
{
    public class EndpointBase
    {
        private readonly GerritConfiguration _configuration;
        private const string SecurityPrefix = ")]}'";

        public EndpointBase(GerritConfiguration configuration)
        {
            _configuration = configuration;
        }

        public TEntity ExecuteRequest<TEntity>(RestRequest restRequest)
        {
            var restClient = new RestClient(_configuration.GerritApiUrl)
            {
                Authenticator = new DigestAuthenticator(_configuration.UserName, _configuration.Password)
            };

            var response = restClient.Execute(restRequest);
            var json = GetJson(response.Content);

            return JsonConvert.DeserializeObject<TEntity>(json);
        }

        private static string GetJson(string responseContent)
        {
            var content = responseContent.StartsWith(SecurityPrefix)
                ? responseContent.Remove(0, SecurityPrefix.Length)
                : responseContent;

            return content.Trim('\n');
        }
    }
}
