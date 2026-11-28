
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The whole settings document, a JSON object of Claude Code managed settings. It replaces any stored document. At most 1 MiB as the server stores it, which can be larger than the request body.
    /// </summary>
    public sealed partial class BetaClaudeCodeRbacGroupManagedSettingsSetParamsSettings
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}