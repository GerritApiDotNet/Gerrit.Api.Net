namespace Gerrit.Api.Domain.Changes
{
    /// <summary>
    ///     The AbandonInput entity contains information for abandoning a change.
    /// </summary>
    public class AbandonInput
    {
        /// <summary>
        ///     Message to be added as review comment to the change when abandoning the change.
        /// </summary>
        public string Message { get; set; }
    }
}