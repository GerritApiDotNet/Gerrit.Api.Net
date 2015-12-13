using System.Text;
using Gerrit.Api.Common.Extensions;

namespace Gerrit.Api.Endpoints.Changes
{
    public class ChangeQueryStringBuilder
    {
        public string GetQueryString(ChangeQueryParameters queryParameters, ChangeOptionalParameters optionalParameters)
        {
            var result = new StringBuilder();

            result.AppendQueryStringPart(GetQueryString(queryParameters));
            result.AppendQueryStringPart(GetQueryString(optionalParameters));
                
            return $"?{result}";
        }

        private static string GetQueryString(ChangeQueryParameters queryParameters)
        {
            var result = new StringBuilder();

            if (queryParameters.NumberOfResults != 0)
                result.AppendQueryStringPart($"n={queryParameters.NumberOfResults}");

            if (queryParameters.Status != null)
                result.AppendQueryStringPart($"status:{queryParameters.Status}");

            if (queryParameters.ReviewedByMe)
                result.AppendQueryStringPart("q=reviewer:self");

            return result.ToString();
        }

        private static string GetQueryString(ChangeOptionalParameters parameters)
        {
            var result = new StringBuilder();

            if (parameters.Labels)
                result.AppendQueryStringPart("o=LABELS");

            if (parameters.DetailedLabels)
                result.AppendQueryStringPart("o=DETAILED_LABELS");

            if (parameters.CurrentRevision)
                result.AppendQueryStringPart("o=CURRENT_REVISION");

            if (parameters.AllRevisions)
                result.AppendQueryStringPart("o=ALL_REVISIONS");

            if (parameters.DownloadCommands)
                result.AppendQueryStringPart("o=DOWNLOAD_COMMANDS");

            if (parameters.DraftComments)
                result.AppendQueryStringPart("o=DRAFT_COMMENTS");

            if (parameters.CurrentCommit)
                result.AppendQueryStringPart("o=CURRENT_COMMIT");

            if (parameters.AllCommits)
                result.AppendQueryStringPart("o=ALL_COMMITS");

            if (parameters.CurrentFiles)
                result.AppendQueryStringPart("o=CURRENT_FILES");

            if (parameters.AllFiles)
                result.AppendQueryStringPart("o=ALL_FILES");

            if (parameters.DetailedAccounts)
                result.AppendQueryStringPart("o=DETAILED_ACCOUNTS");

            if (parameters.Messages)
                result.AppendQueryStringPart("o=MESSAGES");

            if (parameters.CurrentActions)
                result.AppendQueryStringPart("o=CURRENT_ACTIONS");

            if (parameters.ChangeActions)
                result.AppendQueryStringPart("o=CHANGE_ACTIONS");

            if (parameters.Reviewed)
                result.AppendQueryStringPart("o=REVIEWED");

            if (parameters.WebLinks)
                result.AppendQueryStringPart("o=WEB_LINKS");

            if (parameters.Check)
                result.AppendQueryStringPart("o=CHECK");

            return result.ToString();
        }
    }
}