
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Unrestricted network access.
    /// </summary>
    public sealed partial class BetaUnrestrictedNetwork
    {
        /// <summary>
        /// Network policy type
        /// </summary>
        /// <default>"unrestricted"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "unrestricted";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaUnrestrictedNetwork" /> class.
        /// </summary>
        /// <param name="type">
        /// Network policy type
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaUnrestrictedNetwork(
            string type = "unrestricted")
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaUnrestrictedNetwork" /> class.
        /// </summary>
        public BetaUnrestrictedNetwork()
        {
        }
    }
}