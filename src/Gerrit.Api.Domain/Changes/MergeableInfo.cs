using System.Collections.Generic;
using Newtonsoft.Json;

namespace Gerrit.Api.Domain.Changes
{
    /// <summary>
    ///     The MergeableInfo entity contains information about the mergeability of a change.
    /// </summary>
    public class MergeableInfo
    {
        /// <summary>
        ///     Submit type used for this change, can be MERGE_IF_NECESSARY, FAST_FORWARD_ONLY, REBASE_IF_NECESSARY, MERGE_ALWAYS
        ///     or CHERRY_PICK.
        /// </summary>
        [JsonProperty("submit_type")]
        public string SubmitType { get; set; }

        /// <summary>
        ///     true if this change is cleanly mergeable, false otherwise
        /// </summary>
        public bool Mergeable { get; set; }

        /// <summary>
        ///     A list of other branch names where this change could merge cleanly
        /// </summary>
        [JsonProperty("mergeable_into")]
        public List<string> MergeableInto { get; set; }
    }
}