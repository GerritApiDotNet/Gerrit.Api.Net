using System.Collections.Generic;

namespace Gerrit.Api.Domain.Changes
{
    /// <summary>
    ///     The CommitInfo entity contains information about a commit.
    /// </summary>
    public class CommitInfo
    {
        /// <summary>
        ///     The commit ID.
        /// </summary>
        public string Commit { get; set; }

        /// <summary>
        ///     The parent commits of this commit as a list of CommitInfo entities.
        ///     In each parent only the commit and subject fields are populated.
        /// </summary>
        public List<CommitInfo> Parents { get; set; }

        /// <summary>
        ///     The author of the commit as a GitPersonInfo entity.
        /// </summary>
        public GitPersonInfo Author { get; set; }

        /// <summary>
        ///     The committer of the commit as a GitPersonInfo entity.
        /// </summary>
        public GitPersonInfo Committer { get; set; }

        /// <summary>
        ///     The subject of the commit (header line of the commit message).
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        ///     The commit message.
        /// </summary>
        public string Message { get; set; }

        // TODO: web_links
    }
}