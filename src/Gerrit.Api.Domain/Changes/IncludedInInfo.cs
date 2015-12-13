using System.Collections.Generic;

namespace Gerrit.Api.Domain.Changes
{
    /// <summary>
    ///     The IncludedInInfo entity contains information about the branches a change was merged into and tags it was tagged
    ///     with.
    /// </summary>
    public class IncludedInInfo
    {
        /// <summary>
        ///     The list of branches this change was merged into. Each branch is listed without the 'refs/head/' prefix.
        /// </summary>
        public List<string> Branches { get; set; }

        /// <summary>
        ///     The list of tags this change was tagged with. Each tag is listed without the 'refs/tags/' prefix.
        /// </summary>
        public List<string> Tags { get; set; }
    }
}