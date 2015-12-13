using Newtonsoft.Json;

namespace Gerrit.Api.Domain.Changes
{
    public class Labels
    {
        [JsonProperty("Code-Review")]
        public CodeReviewLabel CodeReview { get; set; }

        public VerifiedLabel Verified { get; set; }
    }
}