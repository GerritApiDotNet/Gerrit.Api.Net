namespace Gerrit.Api.Domain.Changes
{
    /// <summary>
    ///     The ActionInfo entity describes a REST API call the client can make to manipulate a resource.
    ///     These are frequently implemented by plugins and may be discovered at runtime.
    /// </summary>
    public class ActionInfo
    {
        /// <summary>
        ///     HTTP method to use with the action. Most actions use POST, PUT or DELETE to cause state changes.
        /// </summary>
        public string Method { get; set; }

        /// <summary>
        ///     Short title to display to a user describing the action. In the Gerrit web interface the label is used as the text
        ///     on the button presented in the UI.
        /// </summary>
        public string Label { get; set; }

        /// <summary>
        ///     Longer text to display describing the action. In a web UI this should be the title attribute of the element,
        ///     displaying when the user hovers the mouse.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        ///     If true the action is permitted at this time and the caller is likely allowed to execute it.
        ///     This may change if state is updated at the server or permissions are modified. Not present if false.
        /// </summary>
        public bool Enabled { get; set; }
    }
}