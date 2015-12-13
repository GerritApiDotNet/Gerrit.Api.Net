namespace Gerrit.Api.Domain.Changes
{
    /// <summary>
    ///     The CherryPickInput entity contains information for cherry-picking a change to a new branch.
    /// </summary>
    public class CherryPickInput
    {
        /// <summary>
        ///     Commit message for the cherry-picked change
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        ///     Destination branch
        /// </summary>
        public string Destination { get; set; }
    }
}