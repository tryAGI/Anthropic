
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Where the executor saved the file, on the executor's filesystem. Only included when another tool in the same environment can read the file at that path.
    /// </summary>
    public sealed partial class BrowserStateChangeDownloadCompletedPath
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}