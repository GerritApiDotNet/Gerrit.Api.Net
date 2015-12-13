using System.Collections.Generic;
using Newtonsoft.Json;

namespace Gerrit.Api.Domain.Changes
{
    /// <summary>
    ///     The DiffFileMetaInfo entity contains meta information about a file diff.
    /// </summary>
    public class DiffFileMetaInfo
    {
        /// <summary>
        ///     The name of the file.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     The content type of the file.
        /// </summary>
        [JsonProperty("content_type")]
        public string ContentType { get; set; }

        /// <summary>
        ///     The total number of lines in the file.
        /// </summary>
        public int Lines { get; set; }

        /// <summary>
        ///     Links to the file in external sites as a list of WebLinkInfo entries.
        /// </summary>
        [JsonProperty("web_links")]
        public List<WebLinkInfo> WebLinks { get; set; }
    }
}