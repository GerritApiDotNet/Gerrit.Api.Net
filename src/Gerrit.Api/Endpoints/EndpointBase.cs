using Gerrit.Api.Authentication;
using Gerrit.Api.Common.Settings;
using Newtonsoft.Json;
using RestSharp;

namespace Gerrit.Api.Endpoints
{
    public class EndpointBase
    {
        private const string SecurityPrefix = ")]}'";

        public TEntity ExecuteRequest<TEntity>(RestRequest restRequest)
        {
            var configuration = ConfigurationProvider.Instance.GetConfiguration();
            var restClient = new RestClient(configuration.GerritApiUrl)
            {
                Authenticator = new DigestAuthenticator(configuration.UserName, configuration.Password)
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
