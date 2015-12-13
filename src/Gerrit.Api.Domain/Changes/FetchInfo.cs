using System.Collections.Generic;

namespace Gerrit.Api.Domain.Changes
{
    /// <summary>
    ///     The FetchInfo entity contains information about how to fetch a patch set via a certain protocol.
    /// </summary>
    public class FetchInfo
    {
        /// <summary>
        ///     The URL of the project.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        ///     The ref of the patch set.
        /// </summary>
        public string Ref { get; set; }

        /// <summary>
        ///     The download commands for this patch set as a map that maps the command names to the commands.
        ///     Only set if download commands are requested.
        /// </summary>
        public Dictionary<string, string> Commands { get; set; }
    }
}