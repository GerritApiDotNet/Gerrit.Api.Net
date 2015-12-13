namespace Gerrit.Api.Domain.Changes
{
    /// <summary>
    ///     The RuleInput entity contains information to test a Prolog rule.
    /// </summary>
    public class RuleInput
    {
        /// <summary>
        ///     Prolog code to execute instead of the code in refs/meta/config.
        /// </summary>
        public string Rule { get; set; }

        /// <summary>
        ///     When RUN filter rules in the parent projects are called to post-process the results of the project specific rule.
        ///     This behavior matches how the rule will execute if installed.
        ///     If SKIP the parent filters are not called, allowing the test to return results from the input rule.
        /// </summary>
        public string Filters { get; set; }
    }
}