
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Populated on creation failure. Null on success. Exactly one of session_id or error is non-null.
    /// </summary>
    public sealed partial class BetaManagedAgentsDeploymentRunError
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}