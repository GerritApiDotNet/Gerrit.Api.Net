using System.Collections.Generic;
using Gerrit.Api.Domain.Changes;

namespace Gerrit.Api.Endpoints.Changes
{
    public interface IChangesEndpoint
    {
        List<ChangeInfo> GetAll(ChangeQueryParameters queryParameters, ChangeOptionalParameters optionalParameters);

        ChangeInfo Get(string changeId, ChangeQueryParameters queryParameters, ChangeOptionalParameters optionalParameters);

        ChangeInfo GetDetails(string changeId, ChangeQueryParameters queryParameters, ChangeOptionalParameters optionalParameters);

        string GetTopic(string changeId);

        Dictionary<string, List<CommentInfo>> GetComments(string changeId);

        Dictionary<string, List<CommentInfo>> GetDraftComments(string changeId);

        ChangeInfo CheckChange(string changeId);
    }
}
