using System.Collections.Generic;
using Newtonsoft.Json;

namespace Gerrit.Api.Domain.Changes
{
    /// <summary>
    ///     The LabelInfo entity contains information about a label on a change, always corresponding to the current patch set.
    ///     There are two options that control the contents of LabelInfo: LABELS and DETAILED_LABELS.
    ///     - For a quick summary of the state of labels, use LABELS.
    ///     - For detailed information about labels, including exact numeric votes for all users and the allowed range of votes
    ///     for the current user, use DETAILED_LABELS.
    /// </summary>
    public class LabelInfo
    {
        /// <summary>
        ///     Whether the label is optional. Optional means the label may be set, but it’s neither necessary for submission nor
        ///     does it block submission if set.
        /// </summary>
        public bool Optional { get; set; }

        /// <summary>
        ///     One user who approved this label on the change (voted the maximum value) as an AccountInfo entity.
        /// </summary>
        public AccountInfo Approved { get; set; }

        /// <summary>
        ///     One user who rejected this label on the change (voted the minimum value) as an AccountInfo entity.
        /// </summary>
        public AccountInfo Rejected { get; set; }

        /// <summary>
        ///     One user who recommended this label on the change (voted positively, but not the maximum value) as an AccountInfo
        ///     entity.
        /// </summary>
        public AccountInfo Recommended { get; set; }

        /// <summary>
        ///     One user who disliked this label on the change (voted negatively, but not the minimum value) as an AccountInfo
        ///     entity.
        /// </summary>
        public AccountInfo Diliked { get; set; }

        /// <summary>
        ///     If true, the label blocks submit operation. If not set, the default is false.
        /// </summary>
        public bool Blocking { get; set; }

        /// <summary>
        ///     The voting value of the user who recommended/disliked this label on the change if it is not “+1”/“-1”.
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        ///     The default voting value for the label. This value may be outside the range specified in permitted_labels.
        /// </summary>
        [JsonProperty("default_value")]
        public string DefaultValue { get; set; }

        /// <summary>
        ///     List of all approvals for this label as a list of ApprovalInfo entities.
        /// </summary>
        public List<ApprovalInfo> All { get; set; }

        /// <summary>
        ///     A map of all values that are allowed for this label. The map maps the values (“-2”, “-1”, " `0`", “+1”, “+2”) to
        ///     the value descriptions.
        /// </summary>
        public Dictionary<string, string> Values { get; set; }
    }
}