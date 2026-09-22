
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The object form of `model` in a request to create a dream.
    /// </summary>
    public sealed partial class BetaDreamModelConfigParams
    {
        /// <summary>
        /// The ID of the model to run the dream with.<br/>
        /// The ID can be 1 to 256 characters long.<br/>
        /// The [limits table in the Dreams guide](https://platform.claude.com/docs/en/managed-agents/dreams#limits) lists the supported models.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// How fast the model generates output for the dream. Defaults to `standard`.<br/>
        /// Dreams accept only `standard`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
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
        /// The ID of the model to run the dream with.<br/>
        /// The ID can be 1 to 256 characters long.<br/>
        /// The [limits table in the Dreams guide](https://platform.claude.com/docs/en/managed-agents/dreams#limits) lists the supported models.
        /// </param>
        /// <param name="speed">
        /// How fast the model generates output for the dream. Defaults to `standard`.<br/>
        /// Dreams accept only `standard`.
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