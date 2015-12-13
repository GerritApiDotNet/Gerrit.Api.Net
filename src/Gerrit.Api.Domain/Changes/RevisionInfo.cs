using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Gerrit.Api.Domain.Changes
{
    /// <summary>
    ///     The RevisionInfo entity contains information about a patch set. Not all fields are returned by default. Additional
    ///     fields can be obtained by adding o parameters as described in Query Changes.
    /// </summary>
    public class RevisionInfo
    {
        /// <summary>
        ///     Whether the patch set is a draft.
        /// </summary>
        public bool Draft { get; set; }

        /// <summary>
        ///     Whether the patch set has one or more draft comments by the calling user. Only set if DRAFT_COMMENTS option is
        ///     requested.
        /// </summary>
        [JsonProperty("has_draft_comments")]
        public bool HasDraftComments { get; set; }

        /// <summary>
        ///     The patch set number.
        /// </summary>
        [JsonProperty("_number")]
        public int Number { get; set; }

        /// <summary>
        ///     The timestamp of when the patch set was created.
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        ///     The uploader of the patch set as an AccountInfo entity.
        /// </summary>
        public AccountInfo Uploader { get; set; }

        /// <summary>
        ///     The Git reference for the patch set.
        /// </summary>
        public string Ref { get; set; }

        /// <summary>
        ///     Information about how to fetch this patch set.
        ///     The fetch information is provided as a map that maps the protocol name (“git”, “http”, “ssh”) to FetchInfo
        ///     entities.
        ///     This information is only included if a plugin implementing the download commands interface is installed.
        /// </summary>
        public Dictionary<string, FetchInfo> Fetch { get; set; }

        /// <summary>
        ///     The commit of the patch set as CommitInfo entity.
        /// </summary>
        public CommitInfo Commit { get; set; }

        /// <summary>
        ///     The files of the patch set as a map that maps the file names to FileInfo entities. Only set if CURRENT_FILES or
        ///     ALL_FILES option is requested.
        /// </summary>
        public Dictionary<string, FileInfo> Files { get; set; }

        /// <summary>
        ///     Actions the caller might be able to perform on this revision. The information is a map of view name to ActionInfo
        ///     entities.
        /// </summary>
        public Dictionary<string, ActionInfo> Actions { get; set; }

        /// <summary>
        ///     Indicates whether the caller is authenticated and has commented on the current revision. Only set if REVIEWED
        ///     option is requested.
        /// </summary>
        public bool Reviewed { get; set; }
    }
}