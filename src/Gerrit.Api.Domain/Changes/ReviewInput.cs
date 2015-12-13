using System.Collections.Generic;
using Newtonsoft.Json;

namespace Gerrit.Api.Domain.Changes
{
    /// <summary>
    ///     The ReviewInput entity contains information for adding a review to a revision.
    /// </summary>
    public class ReviewInput
    {
        /// <summary>
        ///     The message to be added as review comment.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        ///     The votes that should be added to the revision as a map that maps the label names to the voting values.
        /// </summary>
        public Dictionary<string, string> Labels { get; set; }

        /// <summary>
        ///     The comments that should be added as a map that maps a file path to a list of CommentInput entities.
        /// </summary>
        public Dictionary<string, CommentInput> Comments { get; set; }

        /// <summary>
        ///     Whether all labels are required to be within the user’s permitted ranges based on access controls.
        ///     If true, attempting to use a label not granted to the user will fail the entire modify operation early.
        ///     If false, the operation will execute anyway, but the proposed labels will be modified to be the "best" value
        ///     allowed by the access controls.
        /// </summary>
        [JsonProperty("strict_labels")]
        public bool StrictLabels { get; set; }

        /// <summary>
        ///     Draft handling that defines how draft comments are handled that are already in the database but that were not also
        ///     described in this input.
        ///     Allowed values are DELETE, PUBLISH and KEEP.
        ///     If not set, the default is DELETE.
        /// </summary>
        public string Drafts { get; set; }

        /// <summary>
        ///     Notify handling that defines to whom email notifications should be sent after the review is stored.
        ///     Allowed values are NONE, OWNER, OWNER_REVIEWERS and ALL.
        ///     If not set, the default is ALL.
        /// </summary>
        public string Notify { get; set; }

        /// <summary>
        ///     {account-id} the review should be posted on behalf of. To use this option the caller must have been granted
        ///     labelAs-NAME permission for all keys of labels.
        /// </summary>
        [JsonProperty("on_behalf_of")]
        public string OnBehalfOf { get; set; }
    }
}