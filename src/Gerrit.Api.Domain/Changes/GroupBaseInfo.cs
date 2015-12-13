namespace Gerrit.Api.Domain.Changes
{
    /// <summary>
    ///     The GroupBaseInfo entity contains base information about the group.
    /// </summary>
    public class GroupBaseInfo
    {
        /// <summary>
        ///     The id of the group.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        ///     The name of the group.
        /// </summary>
        public string Name { get; set; }
    }
}