namespace Gerrit.Api.Domain.Changes
{
    /// <summary>
    ///     The ChangeEditMessageInput entity contains information for changing the commit message within a change edit.
    /// </summary>
    public class ChangeEditMessageInput
    {
        /// <summary>
        ///     New commit message.
        /// </summary>
        public string Message { get; set; }
    }
}