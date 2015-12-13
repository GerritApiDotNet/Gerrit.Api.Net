using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Gerrit.Api.Domain.Changes
{
    /// <summary>
    ///     The ChangeInfo entity contains information about a change.
    /// </summary>
    public class ChangeInfo
    {
        /// <summary>
        ///     The ID of the change in the format "'<project>~<branch>~<Change-Id>'", where 'project', 'branch' and 'Change-Id' are URL encoded.
        ///     For 'branch' the refs/heads/ prefix is omitted.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        ///     The name of the project.
        /// </summary>
        public string Project { get; set; }

        /// <summary>
        ///     The name of the target branch.
        ///     The refs/heads/ prefix is omitted.
        /// </summary>
        public string Branch { get; set; }

        /// <summary>
        ///     The topic to which this change belongs.
        /// </summary>
        public string Topic { get; set; }

        /// <summary>
        ///     The Change-Id of the change.
        /// </summary>
        [JsonProperty("change_id")]
        public string ChangeId { get; set; }

        /// <summary>
        ///     The subject of the change (header line of the commit message).
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        ///     The status of the change (NEW, SUBMITTED, MERGED, ABANDONED, DRAFT).
        /// </summary>
        [JsonConverter(typeof (StringEnumConverter))]
        public ChangeInfoStatus Status { get; set; }

        /// <summary>
        ///     The timestamp of when the change was created.
        /// </summary>
        public string Created { get; set; }

        /// <summary>
        ///     The timestamp of when the change was last updated.
        /// </summary>
        public string Updated { get; set; }

        /// <summary>
        ///     Whether the calling user has starred this change.
        /// </summary>
        public bool Stared { get; set; }

        /// <summary>
        ///     Whether the change was reviewed by the calling user. Only set if reviewed is requested.
        /// </summary>
        public bool Reviewed { get; set; }

        /// <summary>
        ///     Whether the change is mergeable.
        ///     Not set for merged changes, or if the change has not yet been tested.
        /// </summary>
        public bool Mergeable { get; set; }

        /// <summary>
        ///     Number of inserted lines.
        /// </summary>
        public int Insertions { get; set; }

        /// <summary>
        ///     Number of deleted lines.
        /// </summary>
        public int Deletions { get; set; }

        /// <summary>
        ///     The legacy numeric ID of the change.
        /// </summary>
        [JsonProperty("_number")]
        public int Number { get; set; }

        /// <summary>
        ///     The owner of the change as an AccountInfo entity
        /// </summary>
        public AccountInfo Owner { get; set; }

        /// <summary>
        ///     Actions the caller might be able to perform on this revision. The information is a map of view name to ActionInfo
        ///     entities.
        /// </summary>
        public Dictionary<string, ActionInfo> Actions { get; set; }

        /// <summary>
        ///     The labels of the change as a map that maps the label names to LabelInfo entries.
        ///     Only set if labels or detailed labels are requested.
        /// </summary>
        public Labels Labels { get; set; }

        //TODO: permitted_labels
        //TODO: removable_reviewers

        /// <summary>
        ///     Messages associated with the change as a list of ChangeMessageInfo entities.
        ///     Only set if messages are requested.
        /// </summary>
        public List<ChangeInfoMessage> Messages { get; set; }

        /// <summary>
        ///     The commit ID of the current patch set of this change.
        ///     Only set if the current revision is requested or if all revisions are requested.
        /// </summary>
        [JsonProperty("current_revision")]
        public string CurrentRevision { get; set; }

        /// <summary>
        ///     All patch sets of this change as a map that maps the commit ID of the patch set to a RevisionInfo entity.
        ///     Only set if the current revision is requested(in which case it will only contain a key for the current revision) or
        ///     if all revisions are requested.
        /// </summary>
        public Dictionary<string, RevisionInfo> Revisions { get; set; }

        /// <summary>
        ///     Whether the query would deliver more results if not limited.
        ///     Only set on the last change that is returned.
        /// </summary>
        [JsonProperty("_more_changes")]
        public bool MoreChanges { get; set; }

        /// <summary>
        ///     A list of ProblemInfo entities describing potential problems with this change. Only set if CHECK is set.
        /// </summary>
        public List<ProblemInfo> Problems { get; set; }

        /// <summary>
        ///     A {change-id} that identifies the base change for a create change operation. Only used for the CreateChange
        ///     endpoint.
        /// </summary>
        [JsonProperty("base_change")]
        public string BaseChange { get; set; }
    }
}