using System.Collections.Generic;
using Newtonsoft.Json;

namespace Gerrit.Api.Domain.Changes
{
    /// <summary>
    ///     The EditFileInfo entity contains additional information of a file within a change edit.
    /// </summary>
    public class EditFileInfo
    {
        /// <summary>
        ///     Links to the diff info in external sites as a list of WebLinkInfo entities.
        /// </summary>
        [JsonProperty("web_links")]
        public List<WebLinkInfo> WebLinks { get; set; }
    }
}