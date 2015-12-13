namespace Gerrit.Api.Domain.Changes
{
    /// <summary>
    ///     The RevertInput entity contains information for reverting a change.
    /// </summary>
    public class RevertInput
    {
        /// <summary>
        ///     Message to be added as review comment to the change when reverting the change.
        /// </summary>
        public string Message { get; set; }
    }
}