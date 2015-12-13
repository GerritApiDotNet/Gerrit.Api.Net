using Newtonsoft.Json;

namespace Gerrit.Api.Domain.Changes
{
    /// <summary>
    ///     The DiffWebLinkInfo entity describes a link on a diff screen to an external site.
    /// </summary>
    public class DiffWebLinkInfo
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

        /// <summary>
        ///     Whether the web link should be shown on the side-by-side diff screen.
        /// </summary>
        [JsonProperty("show_on_side_by_side_diff_view")]
        public bool ShowOnSideBySideDiffView { get; set; }

        /// <summary>
        ///     Whether the web link should be shown on the unified diff screen.
        /// </summary>
        [JsonProperty("show_on_unified_diff_view")]
        public bool ShowOnUnifiedDiffView { get; set; }
    }
}