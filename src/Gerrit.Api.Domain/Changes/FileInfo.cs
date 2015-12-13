using Newtonsoft.Json;

namespace Gerrit.Api.Domain.Changes
{
    /// <summary>
    ///     The FileInfo entity contains information about a file in a patch set.
    /// </summary>
    public class FileInfo
    {
        /// <summary>
        ///     The status of the file (“A”=Added, “D”=Deleted, “R”=Renamed, “C”=Copied, “W”=Rewritten).
        ///     Not set if the file was Modified(“M”).
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        ///     Whether the file is binary.
        /// </summary>
        public bool Binary { get; set; }

        /// <summary>
        ///     The old file path.
        ///     Only set if the file was renamed or copied.
        /// </summary>
        [JsonProperty("old_path")]
        public string OldPath { get; set; }

        /// <summary>
        ///     Number of inserted lines.
        ///     Not set for binary files or if no lines were inserted.
        /// </summary>
        [JsonProperty("lines_inserted")]
        public int LinesInserted { get; set; }

        /// <summary>
        ///     Number of deleted lines.
        ///     Not set for binary files or if no lines were deleted.
        /// </summary>
        [JsonProperty("lines_deleted")]
        public int LinesDeleted { get; set; }
    }
}