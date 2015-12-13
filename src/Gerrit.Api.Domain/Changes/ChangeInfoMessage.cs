using Newtonsoft.Json;

namespace Gerrit.Api.Domain.Changes
{
    public class ChangeInfoMessage
    {
        public string Id { get; set; }

        public AccountInfo Author { get; set; }

        public string Date { get; set; }

        public string Message { get; set; }

        [JsonProperty("_revision_number")]
        public int RevisionNumber { get; set; }
    }
}