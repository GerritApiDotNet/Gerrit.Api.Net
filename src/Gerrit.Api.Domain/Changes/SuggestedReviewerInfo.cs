namespace Gerrit.Api.Domain.Changes
{
    /// <summary>
    ///     The SuggestedReviewerInfo entity contains information about a reviewer that can be added to a change (an account or
    ///     a group).
    /// </summary>
    public class SuggestedReviewerInfo
    {
        public AccountInfo Account { get; set; }

        public GroupBaseInfo Group { get; set; }
    }
}