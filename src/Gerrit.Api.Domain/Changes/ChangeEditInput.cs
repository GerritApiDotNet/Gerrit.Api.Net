using Newtonsoft.Json;

namespace Gerrit.Api.Domain.Changes
{
    /// <summary>
    ///     The ChangeEditInput entity contains information for restoring a path within change edit.
    /// </summary>
    public class ChangeEditInput
    {
        [JsonProperty("restore_path")]
        public string RestorePath { get; set; }

        [JsonProperty("old_path")]
        public string OldPath { get; set; }

        [JsonProperty("new_path")]
        public string NewPath { get; set; }
    }
}