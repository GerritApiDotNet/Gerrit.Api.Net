using Newtonsoft.Json;

namespace Gerrit.Api.Domain.Changes
{
    /// <summary>
    ///     The SubmitInput entity contains information for submitting a change.
    /// </summary>
    public class SubmitInput
    {
        /// <summary>
        ///     Whether the request should wait for the merge to complete.
        ///     If false the request returns immediately after the change has been added to the merge queue and
        ///     the caller can’t know whether the change could be merged successfully.
        /// </summary>
        [JsonProperty("wait_for_merge")]
        public bool WaitForMerge { get; set; }
    }
}