
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Model identifier and configuration applied to every pipeline stage.
    /// </summary>
    public sealed partial class BetaDreamModelConfigParams
    {
        /// <summary>
        /// Model identifier, e.g. "claude-opus-4-7". 1-256 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Inference speed mode. Defaults to `standard`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaSpeedJsonConverter))]
        public global::Anthropic.BetaSpeed? Speed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaDreamModelConfigParams" /> class.
        /// </summary>
        /// <param name="id">
        /// Model identifier, e.g. "claude-opus-4-7". 1-256 characters.
        /// </param>
        /// <param name="speed">
        /// Inference speed mode. Defaults to `standard`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaDreamModelConfigParams(
            string id,
            global::Anthropic.BetaSpeed? speed)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Speed = speed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaDreamModelConfigParams" /> class.
        /// </summary>
        public BetaDreamModelConfigParams()
        {
        }

    }
}