using System;
using Newtonsoft.Json;

namespace Gerrit.Api.Domain.Changes
{
    /// <summary>
    ///     The CommentInput entity contains information for creating an inline comment.
    /// </summary>
    public class CommentInput
    {
        /// <summary>
        ///     The URL encoded UUID of the comment if an existing draft comment should be updated.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        ///     The path of the file for which the inline comment should be added.
        ///     Doesn’t need to be set if contained in a map where the key is the file path.
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        ///     The side on which the comment should be added.
        ///     Allowed values are REVISION and PARENT.
        ///     If not set, the default is REVISION.
        /// </summary>
        public string Side { get; set; }

        /// <summary>
        ///     The number of the line for which the comment should be added.
        ///     0 if it is a file comment.
        ///     If neither line nor range is set, a file comment is added.
        ///     If range is set, this value is ignored in favor of the end_line of the range.
        /// </summary>
        public int Line { get; set; }

        // TODO: Range

        /// <summary>
        ///     The URL encoded UUID of the comment to which this comment is a reply.
        /// </summary>
        [JsonProperty("in_reply_to")]
        public string InReplyTo { get; set; }

        /// <summary>
        ///     The timestamp of this comment.
        ///     Accepted but ignored.
        /// </summary>
        public DateTime Updated { get; set; }

        /// <summary>
        ///     The comment message.
        ///     If not set and an existing draft comment is updated, the existing draft comment is deleted.
        /// </summary>
        public string Message { get; set; }
    }
}