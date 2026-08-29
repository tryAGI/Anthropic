
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// JWKS supplied directly; no network fetch.
    /// </summary>
    public sealed partial class BetaJwksInline
    {
        /// <summary>
        /// Inline JWK objects.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keys")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<object> Keys { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"inline"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "inline";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaJwksInline" /> class.
        /// </summary>
        /// <param name="keys">
        /// Inline JWK objects.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaJwksInline(
            global::System.Collections.Generic.IList<object> keys,
            string type = "inline")
        {
            this.Keys = keys ?? throw new global::System.ArgumentNullException(nameof(keys));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaJwksInline" /> class.
        /// </summary>
        public BetaJwksInline()
        {
        }

    }
}