using Newtonsoft.Json;

namespace Gerrit.Api.Domain.Changes
{
    public class Comment
    {
        public string Id { get; set; }

        public int Line { get; set; }

        public string Message { get; set; }

        public string Updated { get; set; }

        public AccountInfo Author { get; set; }

        [JsonProperty("in_reply_to")]
        public string InReplyTo { get; set; }
    }
}