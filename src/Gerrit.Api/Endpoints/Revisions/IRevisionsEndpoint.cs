using System.Collections.Generic;
using Gerrit.Api.Domain.Changes;

namespace Gerrit.Api.Endpoints.Revisions
{
    public interface IRevisionsEndpoint
    {
        CommitInfo GetCommit(string changeId, string revisionId);

        Dictionary<string, ActionInfo> GetRevisionActions(string changeId, string revisionId);

        ChangeInfo GetReview(string changeId, string revisionId);

        RelatedChangesInfo GetRelatedChanges(string changeId, string revisionId);

        Dictionary<string, List<CommentInfo>> GetComments(string changeId, string revisionId);
    }
}
