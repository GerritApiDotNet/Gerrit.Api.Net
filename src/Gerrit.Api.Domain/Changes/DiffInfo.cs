using System.Collections.Generic;
using Newtonsoft.Json;

namespace Gerrit.Api.Domain.Changes
{
    /// <summary>
    ///     The DiffInfo entity contains information about the diff of a file in a revision.
    ///     If the weblinks-only parameter is specified, only the web_links field is set.
    /// </summary>
    public class DiffInfo
    {
        /// <summary>
        ///     Meta information about the file on side A as a DiffFileMetaInfo entity.
        /// </summary>
        [JsonProperty("meta_a")]
        public DiffFileMetaInfo MetaA { get; set; }

        /// <summary>
        ///     Meta information about the file on side B as a DiffFileMetaInfo entity.
        /// </summary>
        [JsonProperty("meta_b")]
        public DiffFileMetaInfo MetaB { get; set; }

        /// <summary>
        ///     The type of change (ADDED, MODIFIED, DELETED, RENAMED COPIED, REWRITE).
        /// </summary>
        [JsonProperty("change_type")]
        public string ChangeType { get; set; }

        /// <summary>
        ///     Intraline status (OK, ERROR, TIMEOUT).
        /// </summary>
        [JsonProperty("intraline_status")]
        public string IntralineStatus { get; set; }

        /// <summary>
        ///     A list of strings representing the patch set diff header.
        /// </summary>
        [JsonProperty("diff_header")]
        public string DiffHeader { get; set; }

        /// <summary>
        ///     The content differences in the file as a list of DiffContent entities.
        /// </summary>
        public List<DiffContent> Content { get; set; }

        /// <summary>
        ///     Links to the file diff in external sites as a list of DiffWebLinkInfo entries.
        /// </summary>
        [JsonProperty("web_links")]
        public List<DiffWebLinkInfo> WebLinks { get; set; }

        /// <summary>
        ///     Whether the file is binary.
        /// </summary>
        public bool Binary { get; set; }
    }
}