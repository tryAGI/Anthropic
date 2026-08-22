
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// One entry in the `fallbacks` chain on a `/v1/messages` request.<br/>
    /// `model` is required. The override fields (`max_tokens`, `thinking`,<br/>
    /// `output_config`, and `speed`) set the corresponding parameter for this<br/>
    /// attempt only and are validated as if the request were made to `model`.<br/>
    /// Any other key is rejected at parse time.
    /// </summary>
    public sealed partial class BetaFallbackConfigV2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// The model that will complete your prompt.<br/>
        /// See [models](https://docs.anthropic.com/en/docs/models-overview) for additional details and options.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.ModelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.Model Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_config")]
        public global::Anthropic.BetaOutputConfig? OutputConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        public global::Anthropic.BetaSpeed? Speed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thinking")]
        public global::Anthropic.ThinkingVariant1? Thinking { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaFallbackConfigV2" /> class.
        /// </summary>
        /// <param name="model">
        /// The model that will complete your prompt.<br/>
        /// See [models](https://docs.anthropic.com/en/docs/models-overview) for additional details and options.
        /// </param>
        /// <param name="maxTokens"></param>
        /// <param name="outputConfig"></param>
        /// <param name="speed"></param>
        /// <param name="thinking"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaFallbackConfigV2(
            global::Anthropic.Model model,
            int? maxTokens,
            global::Anthropic.BetaOutputConfig? outputConfig,
            global::Anthropic.BetaSpeed? speed,
            global::Anthropic.ThinkingVariant1? thinking)
        {
            this.MaxTokens = maxTokens;
            this.Model = model;
            this.OutputConfig = outputConfig;
            this.Speed = speed;
            this.Thinking = thinking;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaFallbackConfigV2" /> class.
        /// </summary>
        public BetaFallbackConfigV2()
        {
        }

    }
}