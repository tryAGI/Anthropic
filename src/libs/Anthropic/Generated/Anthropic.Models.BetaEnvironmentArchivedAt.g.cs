
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// RFC 3339 timestamp when environment was archived, or null if not archived
    /// </summary>
    public sealed partial class BetaEnvironmentArchivedAt
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}