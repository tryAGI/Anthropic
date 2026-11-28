
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The control is off and has no keys.
    /// </summary>
    public sealed partial class BetaCmekControlDisabled
    {
        /// <summary>
        /// Keys that a region has retired, earliest `expires_at` first.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retired_keys")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.BetaRetiredKey> RetiredKeys { get; set; }

        /// <summary>
        /// Default Value: disabled
        /// </summary>
        /// <default>"disabled"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "disabled";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCmekControlDisabled" /> class.
        /// </summary>
        /// <param name="retiredKeys">
        /// Keys that a region has retired, earliest `expires_at` first.
        /// </param>
        /// <param name="type">
        /// Default Value: disabled
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaCmekControlDisabled(
            global::System.Collections.Generic.IList<global::Anthropic.BetaRetiredKey> retiredKeys,
            string type = "disabled")
        {
            this.RetiredKeys = retiredKeys ?? throw new global::System.ArgumentNullException(nameof(retiredKeys));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCmekControlDisabled" /> class.
        /// </summary>
        public BetaCmekControlDisabled()
        {
        }

    }
}