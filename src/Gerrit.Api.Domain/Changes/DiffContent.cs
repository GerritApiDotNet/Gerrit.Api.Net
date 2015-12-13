using Newtonsoft.Json;

namespace Gerrit.Api.Domain.Changes
{
    /// <summary>
    ///     The DiffContent entity contains information about the content differences in a file.
    /// </summary>
    public class DiffContent
    {
        /// <summary>
        ///     Content only in the file on side A (deleted in B).
        /// </summary>
        public string A { get; set; }

        /// <summary>
        ///     Content only in the file on side B (added in B).
        /// </summary>
        public string B { get; set; }

        /// <summary>
        ///     Content in the file on both sides (unchanged).
        /// </summary>
        public string AB { get; set; }

        /// <summary>
        ///     Text sections deleted from side A as a DiffIntralineInfo entity.
        /// </summary>
        [JsonProperty("edit_a")]
        public DiffIntralineInfo EditA { get; set; }

        /// <summary>
        ///     Text sections inserted in side B as a DiffIntralineInfo entity.
        /// </summary>
        [JsonProperty("edit_b")]
        public DiffIntralineInfo EditB { get; set; }

        /// <summary>
        ///     count of lines skipped on both sides when the file is too large to include all common lines.
        /// </summary>
        public int Skip { get; set; }

        /// <summary>
        ///     Set to true if the region is common according to the requested ignore-whitespace parameter,
        ///     but a and b contain differing amounts of whitespace. When present and true a and b are used
        ///     instead of ab.
        /// </summary>
        public bool Common { get; set; }
    }
}