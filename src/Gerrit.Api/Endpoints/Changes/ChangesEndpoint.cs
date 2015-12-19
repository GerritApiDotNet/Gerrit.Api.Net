using System.Collections.Generic;
using Gerrit.Api.Common.Configuration;
using Gerrit.Api.Domain.Changes;
using Gerrit.Api.Endpoints.Runner;
using RestSharp;

namespace Gerrit.Api.Endpoints.Changes
{
    public class ChangesEndpoint : IChangesEndpoint
    {
        private readonly IRestRequestRunner _requestRunner;
        private readonly ChangeQueryStringBuilder _queryStringBuilder = new ChangeQueryStringBuilder();

        public ChangesEndpoint(GerritConfiguration gerritConfiguration) : this(new RestRequestRunner(gerritConfiguration))
        {
        }

        public ChangesEndpoint(IRestRequestRunner requestRunner)
        {
            _requestRunner = requestRunner;
        }

        public List<ChangeInfo> GetAll(ChangeQueryParameters queryParameters, ChangeOptionalParameters optionalParameters)
        {
            var restRequest = GetRestRequest("/changes", queryParameters, optionalParameters);

            return _requestRunner.ExecuteRequest<List<ChangeInfo>>(restRequest, Method.GET);
        }

        public ChangeInfo Get(string changeId, ChangeQueryParameters queryParameters, ChangeOptionalParameters optionalParameters)
        {
            var restRequest = GetRestRequest($"/changes/{changeId}", queryParameters, optionalParameters);

            return _requestRunner.ExecuteRequest<ChangeInfo>(restRequest, Method.GET);
        }

        public ChangeInfo GetDetails(string changeId, ChangeQueryParameters queryParameters, ChangeOptionalParameters optionalParameters)
        {
            var restRequest = GetRestRequest($"/changes/{changeId}/detail", queryParameters, optionalParameters);

            return _requestRunner.ExecuteRequest<ChangeInfo>(restRequest, Method.GET);
        }

        public string GetTopic(string changeId)
        {
            var restRequest = GetRestRequest($"/changes/{changeId}/topic");

            return _requestRunner.ExecuteRequest<string>(restRequest, Method.GET);
        }

        public Dictionary<string, List<CommentInfo>> GetComments(string changeId)
        {
            var restRequest = GetRestRequest($"/changes/{changeId}/comments");

            return _requestRunner.ExecuteRequest<Dictionary<string, List<CommentInfo>>>(restRequest, Method.GET);
        }

        public Dictionary<string, List<CommentInfo>> GetDraftComments(string changeId)
        {
            var restRequest = GetRestRequest($"/changes/{changeId}/drafts");

            return _requestRunner.ExecuteRequest<Dictionary<string, List<CommentInfo>>>(restRequest, Method.GET);
        }

        public ChangeInfo CheckChange(string changeId)
        {
            var restRequest = GetRestRequest($"/changes/{changeId}/check");

            return _requestRunner.ExecuteRequest<ChangeInfo>(restRequest, Method.GET);
        }

        private string GetRestRequest(string url)
        {
            return GetRestRequest(url, ChangeQueryParameters.Empty, ChangeOptionalParameters.Empty);
        }

        private string GetRestRequest(string url, ChangeQueryParameters queryParameters, ChangeOptionalParameters optionalParameters)
        {
            return $"{url}/{_queryStringBuilder.GetQueryString(queryParameters, optionalParameters)}";
        }
    }
}
