using Newtonsoft.Json;

namespace Gerrit.Api.Domain.Changes
{
    /// <summary>
    ///     The WebLinkInfo entity describes a link to an external site.
    /// </summary>
    public class WebLinkInfo
    {
        /// <summary>
        ///     The link name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     The link URL.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        ///     URL to the icon of the link.
        /// </summary>
        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }
    }
}