using System;

namespace Gerrit.Api.Domain.Changes
{
    /// <summary>
    ///     The GitPersonInfo entity contains information about the author/committer of a commit.
    /// </summary>
    public class GitPersonInfo
    {
        /// <summary>
        ///     The name of the author/committer.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     The email address of the author/committer.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        ///     The timestamp of when this identity was constructed.
        /// </summary>
        public DateTime Date { get; set; }

        // TODO: tz
    }
}