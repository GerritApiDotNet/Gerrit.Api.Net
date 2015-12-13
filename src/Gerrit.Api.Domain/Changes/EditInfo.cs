using System.Collections.Generic;

namespace Gerrit.Api.Domain.Changes
{
    /// <summary>
    ///     The EditInfo entity contains information about a change edit.
    /// </summary>
    public class EditInfo
    {
        /// <summary>
        ///     The commit of change edit as CommitInfo entity.
        /// </summary>
        public CommitInfo Commit { get; set; }

        /// <summary>
        ///     The revision of the patch set change edit is based on.
        /// </summary>
        public string BaseRevision { get; set; }

        /// <summary>
        ///     Information about how to fetch this patch set.
        ///     The fetch information is provided as a map that maps the protocol name (“git”, “http”, “ssh”) to FetchInfo
        ///     entities.
        /// </summary>
        public Dictionary<string, FetchInfo> Fetch { get; set; }

        /// <summary>
        ///     The files of the change edit as a map that maps the file names to FileInfo entities.
        /// </summary>
        public Dictionary<string, FileInfo> Files { get; set; }
    }
}