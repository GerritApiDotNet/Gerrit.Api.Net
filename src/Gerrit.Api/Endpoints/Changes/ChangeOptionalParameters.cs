namespace Gerrit.Api.Endpoints.Changes
{
    public class ChangeOptionalParameters
    {
        public static ChangeOptionalParameters Empty => new ChangeOptionalParameters();

        public bool Labels { get; set; }

        public bool DetailedLabels { get; set; }

        public bool CurrentRevision { get; set; }

        public bool AllRevisions { get; set; }

        public bool DownloadCommands { get; set; }

        public bool DraftComments { get; set; }

        public bool CurrentCommit { get; set; }

        public bool AllCommits { get; set; }

        public bool CurrentFiles { get; set; }

        public bool AllFiles { get; set; }

        public bool DetailedAccounts { get; set; }

        public bool Messages { get; set; }

        public bool CurrentActions { get; set; }

        public bool ChangeActions { get; set; }

        public bool Reviewed { get; set; }

        public bool WebLinks { get; set; }

        public bool Check { get; set; }
    }
}