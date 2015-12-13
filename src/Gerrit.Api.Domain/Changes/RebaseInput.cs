namespace Gerrit.Api.Domain.Changes
{
    /// <summary>
    ///     The RebaseInput entity contains information for changing parent when rebasing.
    /// </summary>
    public class RebaseInput
    {
        /// <summary>
        ///     The new parent revision. This can be a ref or a SHA1 to a concrete patchset.
        ///     Alternatively, a change number can be specified, in which case the current patch set is inferred.
        ///     Empty string is used for rebasing directly on top of the target branch, which effectively breaks dependency towards
        ///     a parent change.
        /// </summary>
        public string Base { get; set; }
    }
}