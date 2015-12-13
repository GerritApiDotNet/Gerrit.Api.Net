using System.Collections.Generic;

namespace Gerrit.Api.Domain.Changes
{
    /// <summary>
    ///     The RelatedChangesInfo entity contains information about related changes.
    /// </summary>
    public class RelatedChangesInfo
    {
        /// <summary>
        ///     A list of RelatedChangeAndCommitInfo entities describing the related changes. Sorted by git commit order, newest to
        ///     oldest. Empty if there are no related changes.
        /// </summary>
        public List<RelatedChangeAndCommitInfo> Changes { get; set; }
    }
}