using System;

namespace Gerrit.Api.Domain.Changes
{
    /// <summary>
    ///     The ApprovalInfo entity contains information about an approval from a user for a label on a change.
    /// </summary>
    public class ApprovalInfo
    {
        /// <summary>
        ///     The vote that the user has given for the label. If present and zero, the user is permitted to vote on the label.
        ///     If absent, the user is not permitted to vote on that label.
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        ///     The time and date describing when the approval was made.
        /// </summary>
        public DateTime Date { get; set; }
    }
}