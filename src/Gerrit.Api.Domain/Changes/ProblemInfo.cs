namespace Gerrit.Api.Domain.Changes
{
    /// <summary>
    ///     The ProblemInfo entity contains a description of a potential consistency problem with a change. These are not
    ///     related to the code review process, but rather indicate some inconsistency in Gerrit’s database or repository
    ///     metadata related to the enclosing change.
    /// </summary>
    public class ProblemInfo
    {
        /// <summary>
        ///     Plaintext message describing the problem with the change.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        ///     The status of fixing the problem (FIXED, FIX_FAILED). Only set if a fix was attempted.
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        ///     If status is set, an additional plaintext message describing the outcome of the fix.
        /// </summary>
        public string Outcome { get; set; }
    }
}