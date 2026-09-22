
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The model that runs a dream, from the request that created it.<br/>
    /// The dream uses this model for all of its work. The response always gives the model as an object, even if the request gave only a model ID.
    /// </summary>
    public sealed partial class BetaDreamModelConfig
    {
        /// <summary>
        /// The ID of the model that runs the dream, as given in the request that created it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// How fast the model generates output for the dream. Always `standard`.
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
        /// Initializes a new instance of the <see cref="BetaDreamModelConfig" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the model that runs the dream, as given in the request that created it.
        /// </param>
        /// <param name="speed">
        /// How fast the model generates output for the dream. Always `standard`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaDreamModelConfig(
            string id,
            global::Anthropic.BetaSpeed? speed)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Speed = speed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaDreamModelConfig" /> class.
        /// </summary>
        public BetaDreamModelConfig()
        {
        }

    }
}