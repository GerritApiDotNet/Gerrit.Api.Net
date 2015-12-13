using System.Collections.Generic;

namespace Gerrit.Api.Domain.Changes
{
    /// <summary>
    ///     The ReviewerInfo entity contains information about a reviewer and its votes on a change.
    /// </summary>
    public class ReviewerInfo : AccountInfo
    {
        /// <summary>
        ///     The approvals of the reviewer as a map that maps the label names to the approval values (“-2”, “-1”, “0”, “+1”,
        ///     “+2”).
        /// </summary>
        public Dictionary<string, string> Approvals { get; set; }
    }
}