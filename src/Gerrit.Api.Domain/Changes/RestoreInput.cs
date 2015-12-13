namespace Gerrit.Api.Domain.Changes
{
    /// <summary>
    ///     The RestoreInput entity contains information for restoring a change.
    /// </summary>
    public class RestoreInput
    {
        /// <summary>
        ///     Message to be added as review comment to the change when restoring the change.
        /// </summary>
        public string Message { get; set; }
    }
}