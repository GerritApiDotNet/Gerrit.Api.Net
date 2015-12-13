using System.Collections.Generic;

namespace Gerrit.Api.Domain.Changes
{
    /// <summary>
    ///     The AddReviewerResult entity describes the result of adding a reviewer to a change.
    /// </summary>
    public class AddReviewerResult
    {
        /// <summary>
        ///     The newly added reviewers as a list of ReviewerInfo entities.
        /// </summary>
        public List<ReviewerInfo> Reviewers { get; set; }

        /// <summary>
        ///     Error message explaining why the reviewer could not be added.
        ///     If a group was specified in the input and an error is returned, it means that none of the members were added as
        ///     reviewer.
        /// </summary>
        public string Error { get; set; }

        /// <summary>
        ///     Whether adding the reviewer requires confirmation.
        /// </summary>
        public bool Confirm { get; set; }
    }
}