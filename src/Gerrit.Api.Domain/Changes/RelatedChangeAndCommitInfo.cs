using Newtonsoft.Json;

namespace Gerrit.Api.Domain.Changes
{
    /// <summary>
    ///     The RelatedChangeAndCommitInfo entity contains information about a related change and commit.
    /// </summary>
    public class RelatedChangeAndCommitInfo
    {
        /// <summary>
        ///     The Change-Id of the change.
        /// </summary>
        [JsonProperty("change_id")]
        public string ChangeId { get; set; }

        /// <summary>
        ///     The commit as a CommitInfo entity.
        /// </summary>
        public CommitInfo Commit { get; set; }

        /// <summary>
        ///     The change number.
        /// </summary>
        [JsonProperty("_change_number")]
        public int ChangeNumber { get; set; }

        /// <summary>
        ///     The revision number.
        /// </summary>
        [JsonProperty("_revision_number")]
        public int RevisionNumber { get; set; }

        /// <summary>
        ///     The current revision number.
        /// </summary>
        [JsonProperty("_current_revision_number")]
        public int CurrentRevisionNumber { get; set; }
    }
}