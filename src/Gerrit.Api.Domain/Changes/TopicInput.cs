namespace Gerrit.Api.Domain.Changes
{
    /// <summary>
    ///     The TopicInput entity contains information for setting a topic.
    /// </summary>
    public class TopicInput
    {
        /// <summary>
        ///     The topic.
        ///     The topic will be deleted if not set.
        /// </summary>
        public string Topic { get; set; }
    }
}