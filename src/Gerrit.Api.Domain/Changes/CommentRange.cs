using Newtonsoft.Json;

namespace Gerrit.Api.Domain.Changes
{
    /// <summary>
    ///     The CommentRange entity describes the range of an inline comment.
    /// </summary>
    public class CommentRange
    {
        /// <summary>
        ///     The start line number of the range.
        /// </summary>
        [JsonProperty("start_line")]
        public int StartLine { get; set; }

        /// <summary>
        ///     The character position in the start line.
        /// </summary>
        [JsonProperty("start_character")]
        public int StartCharacter { get; set; }

        /// <summary>
        ///     The end line number of the range.
        /// </summary>
        [JsonProperty("end_line")]
        public int EndLine { get; set; }

        /// <summary>
        ///     The character position in the end line.
        /// </summary>
        [JsonProperty("end_character")]
        public int EndCharacter { get; set; }
    }
}