
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The ID and type of the actor that created the API key, or `null` when the<br/>
    /// creator is not recorded (legacy, workload-identity-federated, or<br/>
    /// system-created keys).
    /// </summary>
    public sealed partial class BetaApiKeyCreatedBy
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}