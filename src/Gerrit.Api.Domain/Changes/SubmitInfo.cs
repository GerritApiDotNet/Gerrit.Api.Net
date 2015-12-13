using Newtonsoft.Json;

namespace Gerrit.Api.Domain.Changes
{
    /// <summary>
    ///     The SubmitInfo entity contains information about the change status after submitting.
    /// </summary>
    public class SubmitInfo
    {
        /// <summary>
        ///     The status of the change after submitting, can be MERGED or SUBMITTED.
        ///     If wait_for_merge in the SubmitInput was set to false the returned status is SUBMITTED and the caller can’t know
        ///     whether the change could be merged successfully.
        /// </summary>
        public string Status { get; set; }

        [JsonProperty("on_behalf_of")]
        public string OnBehalfOf { get; set; }
    }
}