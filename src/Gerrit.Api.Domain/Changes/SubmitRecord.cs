using Newtonsoft.Json;

namespace Gerrit.Api.Domain.Changes
{
    /// <summary>
    ///     The SubmitRecord entity describes results from a submit_rule.
    /// </summary>
    public class SubmitRecord
    {
        /// <summary>
        ///     OK, the change can be submitted.
        ///     NOT_READY, additional labels are required before submit.
        ///     CLOSED, closed changes cannot be submitted.
        ///     RULE_ERROR, rule code failed with an error.
        /// </summary>
        public string Status { get; set; }

        // TODO: ok
        // TODO: reject
        // TODO: need
        // TODO: may
        // TODO: impossible

        /// <summary>
        ///     When status is RULE_ERROR this message provides some text describing the failure of the rule predicate.
        /// </summary>
        [JsonProperty("error_message")]
        public string ErrorMessage { get; set; }
    }
}