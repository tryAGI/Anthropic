
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Configuration for self-hosted environments.
    /// </summary>
    public sealed partial class BetaSelfHostedConfig
    {
        /// <summary>
        /// Environment type
        /// </summary>
        /// <default>"self_hosted"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "self_hosted";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaSelfHostedConfig" /> class.
        /// </summary>
        /// <param name="type">
        /// Environment type
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaSelfHostedConfig(
            string type = "self_hosted")
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaSelfHostedConfig" /> class.
        /// </summary>
        public BetaSelfHostedConfig()
        {
        }

    }
}