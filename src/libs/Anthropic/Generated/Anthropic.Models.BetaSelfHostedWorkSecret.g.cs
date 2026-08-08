
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Credential payload used by the environment worker to execute this work item. May be populated when polling for work; null on all other retrieval paths.
    /// </summary>
    public sealed partial class BetaSelfHostedWorkSecret
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}