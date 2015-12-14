using System;
using Newtonsoft.Json;

namespace Gerrit.Api.Domain.Changes
{
    /// <summary>
    ///     The CommentInfo entity contains information about an inline comment.
    /// </summary>
    public class CommentInfo
    {
        /// <summary>
        ///     The URL encoded UUID of the comment.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        ///     The path of the file for which the inline comment was done.
        ///     Not set if returned in a map where the key is the file path.
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        ///     The side on which the comment was added.
        ///     Allowed values are REVISION and PARENT.
        ///     If not set, the default is REVISION.
        /// </summary>
        public string Side { get; set; }

        /// <summary>
        ///     The number of the line for which the comment was done.
        ///     If range is set, this equals the end line of the range.
        ///     If neither line nor range is set, it’s a file comment.
        /// </summary>
        public int Line { get; set; }

        /// <summary>
        ///     The range of the comment as a CommentRange entity.
        /// </summary>
        public CommentRange Range { get; set; }

        /// <summary>
        ///     The URL encoded UUID of the comment to which this comment is a reply.
        /// </summary>
        [JsonProperty("in_reply_to")]
        public string InReplyTo { get; set; }

        /// <summary>
        ///     The comment message.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        ///     The timestamp of when this comment was written.
        /// </summary>
        public DateTime Updated { get; set; }

        /// <summary>
        ///     The author of the message as an AccountInfo entity.
        ///     Unset for draft comments, assumed to be the calling user.
        /// </summary>
        public AccountInfo Author { get; set; }
    }
}