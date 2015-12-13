namespace Gerrit.Api.Domain.Changes
{
    /// <summary>
    ///     The DiffIntralineInfo entity contains information about intraline edits in a file.
    ///     The information consists of a list of (skip length, mark length) pairs, where the skip length
    ///     is the number of characters between the end of the previous edit and the start of this edit,
    ///     and the mark length is the number of edited characters following the skip.
    ///     The start of the edits is from the beginning of the related diff content lines.
    ///     Note that the implied newline character at the end of each line is included in the length calculation,
    ///     and thus it is possible for the edits to span newlines.
    /// </summary>
    public class DiffIntralineInfo
    {
    }
}