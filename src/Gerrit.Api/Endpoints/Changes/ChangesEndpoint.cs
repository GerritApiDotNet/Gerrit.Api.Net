using System.Collections.Generic;
using Gerrit.Api.Common.Configuration;
using Gerrit.Api.Domain.Changes;
using RestSharp;

namespace Gerrit.Api.Endpoints.Changes
{
    public class ChangesEndpoint : EndpointBase, IChangesEndpoint
    {
        private readonly ChangeQueryStringBuilder _queryStringBuilder = new ChangeQueryStringBuilder();

        public ChangesEndpoint(GerritConfiguration configuration) : base(configuration)
        {
        }

        public List<ChangeInfo> GetAll(ChangeQueryParameters queryParameters, ChangeOptionalParameters optionalParameters)
        {
            var restRequest = GetRestRequest("/changes", queryParameters, optionalParameters);

            return ExecuteRequest<List<ChangeInfo>>(restRequest);
        }

        public ChangeInfo Get(string changeId, ChangeQueryParameters queryParameters, ChangeOptionalParameters optionalParameters)
        {
            var restRequest = GetRestRequest($"/changes/{changeId}", queryParameters, optionalParameters);

            return ExecuteRequest<ChangeInfo>(restRequest);
        }

        public ChangeInfo GetDetails(string changeId, ChangeQueryParameters queryParameters, ChangeOptionalParameters optionalParameters)
        {
            var restRequest = GetRestRequest($"/changes/{changeId}/detail", queryParameters, optionalParameters);

            return ExecuteRequest<ChangeInfo>(restRequest);
        }

        public string GetTopic(string changeId)
        {
            var restRequest = GetRestRequest($"/changes/{changeId}/topic");

            return ExecuteRequest<string>(restRequest);
        }

        public Dictionary<string, List<CommentInfo>> GetComments(string changeId)
        {
            var restRequest = GetRestRequest($"/changes/{changeId}/comments");

            return ExecuteRequest<Dictionary<string, List<CommentInfo>>>(restRequest);
        }

        public Dictionary<string, List<CommentInfo>> GetDraftComments(string changeId)
        {
            var restRequest = GetRestRequest($"/changes/{changeId}/drafts");

            return ExecuteRequest<Dictionary<string, List<CommentInfo>>>(restRequest);
        }

        public ChangeInfo CheckChange(string changeId)
        {
            var restRequest = GetRestRequest($"/changes/{changeId}/check");

            return ExecuteRequest<ChangeInfo>(restRequest);
        }

        private RestRequest GetRestRequest(string url)
        {
            return GetRestRequest(url, ChangeQueryParameters.Empty, ChangeOptionalParameters.Empty);
        }

        private RestRequest GetRestRequest(string url, ChangeQueryParameters queryParameters, ChangeOptionalParameters optionalParameters)
        {
            var queryString = _queryStringBuilder.GetQueryString(queryParameters, optionalParameters);
            return new RestRequest($"{url}/{queryString}", Method.GET);
        }
    }
}
