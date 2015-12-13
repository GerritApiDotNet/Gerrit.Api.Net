using System.Collections.Generic;

namespace Gerrit.Api.Domain.Changes
{
    /// <summary>
    ///     The ReviewInfo entity contains information about a review.
    /// </summary>
    public class ReviewInfo
    {
        /// <summary>
        ///     The labels of the review as a map that maps the label names to the voting values.
        /// </summary>
        public Dictionary<string, string> Labels { get; set; }
    }
}