using Gerrit.Api.Authentication;
using Gerrit.Api.Common.Configuration;
using Newtonsoft.Json;
using RestSharp;

namespace Gerrit.Api.Endpoints.Runner
{
    public class RestRequestRunner : IRestRequestRunner
    {
        private readonly IRestClient _restClient;
        private const string SecurityPrefix = ")]}'";

        public RestRequestRunner(GerritConfiguration gerritConfiguration)
        {
            _restClient = new RestClient(gerritConfiguration.GerritApiUrl)
            {
                Authenticator = new DigestAuthenticator(gerritConfiguration.UserName, gerritConfiguration.Password)
            };
        }

        public TEntity ExecuteRequest<TEntity>(string resource, Method method)
        {
            var response = _restClient.Execute(new RestRequest(resource, method));
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
