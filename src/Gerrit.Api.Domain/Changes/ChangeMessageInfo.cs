using System;
using Newtonsoft.Json;

namespace Gerrit.Api.Domain.Changes
{
    /// <summary>
    ///     The ChangeMessageInfo entity contains information about a message attached to a change.
    /// </summary>
    public class ChangeMessageInfo
    {
        /// <summary>
        ///     The ID of the message.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        ///     Author of the message as an AccountInfo entity.
        ///     Unset if written by the Gerrit system.
        /// </summary>
        public AccountInfo Author { get; set; }

        /// <summary>
        ///     The timestamp this message was posted.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        ///     The text left by the user.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        ///     Which patchset (if any) generated this message.
        /// </summary>
        [JsonProperty("_revision_number")]
        public string RevisionNumber { get; set; }
    }
}