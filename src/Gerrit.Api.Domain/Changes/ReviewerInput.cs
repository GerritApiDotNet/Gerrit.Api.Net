namespace Gerrit.Api.Domain.Changes
{
    /// <summary>
    ///     The ReviewerInput entity contains information for adding a reviewer to a change.
    /// </summary>
    public class ReviewerInput
    {
        /// <summary>
        ///     The ID of one account that should be added as reviewer or the ID of one group for which all members should be added
        ///     as reviewers.
        ///     If an ID identifies both an account and a group, only the account is added as reviewer to the change.
        /// </summary>
        public string Reviewer { get; set; }

        /// <summary>
        ///     Whether adding the reviewer is confirmed.
        ///     The Gerrit server may be configured to require a confirmation when adding a group as reviewer that has many
        ///     members.
        /// </summary>
        public bool Confirmed { get; set; }
    }
}