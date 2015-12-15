using System.Collections.Generic;
using Gerrit.Api.Common.Configuration;
using Gerrit.Api.Domain.Changes;
using RestSharp;

namespace Gerrit.Api.Endpoints.Revisions
{
    public class RevisionsEndpoint : EndpointBase, IRevisionsEndpoint
    {
        public RevisionsEndpoint(GerritConfiguration configuration) : base(configuration)
        {
        }

        public CommitInfo GetCommit(string changeId, string revisionId)
        {
            var restRequest = new RestRequest($"/changes/{changeId}/revisions/{revisionId}/commit", Method.GET);

            return ExecuteRequest<CommitInfo>(restRequest);
        }

        public Dictionary<string, ActionInfo> GetRevisionActions(string changeId, string revisionId)
        {
            var restRequest = new RestRequest($"/changes/{changeId}/revisions/{revisionId}/actions", Method.GET);

            return ExecuteRequest<Dictionary<string, ActionInfo>>(restRequest);
        }

        public ChangeInfo GetReview(string changeId, string revisionId)
        {
            var restRequest = new RestRequest($"/changes/{changeId}/revisions/{revisionId}/review", Method.GET);

            return ExecuteRequest<ChangeInfo>(restRequest);
        }

        public RelatedChangesInfo GetRelatedChanges(string changeId, string revisionId)
        {
            var restRequest = new RestRequest($"/changes/{changeId}/revisions/{revisionId}/related", Method.GET);

            return ExecuteRequest<RelatedChangesInfo>(restRequest);
        }

        public Dictionary<string, List<CommentInfo>> GetComments(string changeId, string revisionId)
        {
            var restRequest = new RestRequest($"/changes/{changeId}/revisions/{revisionId}/comments", Method.GET);

            return ExecuteRequest<Dictionary<string, List<CommentInfo>>>(restRequest);
        }
    }
}
