using System.Collections.Generic;
using Gerrit.Api.Common.Configuration;
using Gerrit.Api.Domain.Changes;
using Gerrit.Api.Endpoints.Runner;
using RestSharp;

namespace Gerrit.Api.Endpoints.Revisions
{
    public class RevisionsEndpoint : IRevisionsEndpoint
    {
        private readonly IRestRequestRunner _restRequestRunner;

        public RevisionsEndpoint(GerritConfiguration gerritConfiguration) 
            : this(new RestRequestRunner(gerritConfiguration))
        {
        }

        public RevisionsEndpoint(IRestRequestRunner restRequestRunner)
        {
            _restRequestRunner = restRequestRunner;
        }

        public CommitInfo GetCommit(string changeId, string revisionId)
        {
            return _restRequestRunner.ExecuteRequest<CommitInfo>($"/changes/{changeId}/revisions/{revisionId}/commit", Method.GET);
        }

        public Dictionary<string, ActionInfo> GetRevisionActions(string changeId, string revisionId)
        {
            return _restRequestRunner.ExecuteRequest<Dictionary<string, ActionInfo>>($"/changes/{changeId}/revisions/{revisionId}/actions", Method.GET);
        }

        public ChangeInfo GetReview(string changeId, string revisionId)
        {
            return _restRequestRunner.ExecuteRequest<ChangeInfo>($"/changes/{changeId}/revisions/{revisionId}/review", Method.GET);
        }

        public RelatedChangesInfo GetRelatedChanges(string changeId, string revisionId)
        {
            return _restRequestRunner.ExecuteRequest<RelatedChangesInfo>($"/changes/{changeId}/revisions/{revisionId}/related", Method.GET);
        }

        public Dictionary<string, List<CommentInfo>> GetComments(string changeId, string revisionId)
        {
            return _restRequestRunner.ExecuteRequest<Dictionary<string, List<CommentInfo>>>($"/changes/{changeId}/revisions/{revisionId}/comments", Method.GET);
        }
    }
}
