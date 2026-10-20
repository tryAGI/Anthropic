
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
        /// The `max_tokens` for the fallback attempt that uses this `fallbacks` entry's `model`, in place of the request's `max_tokens`. If you leave it out or set it to `null`, the attempt uses the request's `max_tokens`.<br/>
        /// See the [refusals and fallback guide](https://platform.claude.com/docs/en/build-with-claude/refusals-and-fallback#naming-your-own-fallback-models) to learn more about fallback entries.
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
        /// Output parameters for the fallback attempt that uses this `fallbacks` entry's `model`, combined with the request's `output_config` one field at a time.<br/>
        /// - `format`: If you leave it out, the attempt uses the request's `format`. If you set it to `null`, the attempt runs without a format.<br/>
        /// - `effort`: If you leave it out, the attempt uses the request's `effort` when `model` supports that level with the attempt's `thinking`. If the request doesn't set `effort`, if `model` doesn't support the level, or if you set `effort` to `null`, the attempt runs at the default effort of `model`.<br/>
        /// - `task_budget`: If you leave it out, the attempt uses the request's `task_budget` when `model` accepts a task budget of that size. If the request doesn't set `task_budget`, if `model` doesn't accept it, or if you set `task_budget` to `null`, the attempt runs without a task budget.<br/>
        /// Set `output_config` to `null` to run the attempt without a format or a task budget, at the default effort of `model`.<br/>
        /// These rules apply with the `server-side-fallback-2026-07-01` beta header.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_config")]
        public global::Anthropic.BetaOutputConfig? OutputConfig { get; set; }

        /// <summary>
        /// The inference speed mode for the fallback attempt that uses this `fallbacks` entry's `model`. If you leave it out, the attempt runs at `fast` speed only when the request sets `speed` to `fast` and your organization can use fast mode on `model`.<br/>
        /// Otherwise, or when you set this field to `null`, the attempt runs at `standard` speed.<br/>
        /// These rules apply with the `server-side-fallback-2026-07-01` beta header.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        public global::Anthropic.BetaSpeed? Speed { get; set; }

        /// <summary>
        /// The thinking configuration for the fallback attempt that uses this `fallbacks` entry's `model`. If you leave it out, the attempt uses the request's `thinking` when `model` supports that thinking `type`.<br/>
        /// If you leave it out and the request's thinking `type` is `between_tools` but `model` doesn't support `between_tools`, the attempt uses `disabled` if `model` supports it. Otherwise, if `model` doesn't support the request's thinking `type`, if the request doesn't set `thinking`, or if you set this field to `null`, the attempt uses the thinking `type` that `model` uses when a request leaves out `thinking`. The request's `thinking.display` still applies where `model` allows it.<br/>
        /// These rules apply with the `server-side-fallback-2026-07-01` beta header.
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
        /// <param name="maxTokens">
        /// The `max_tokens` for the fallback attempt that uses this `fallbacks` entry's `model`, in place of the request's `max_tokens`. If you leave it out or set it to `null`, the attempt uses the request's `max_tokens`.<br/>
        /// See the [refusals and fallback guide](https://platform.claude.com/docs/en/build-with-claude/refusals-and-fallback#naming-your-own-fallback-models) to learn more about fallback entries.
        /// </param>
        /// <param name="outputConfig">
        /// Output parameters for the fallback attempt that uses this `fallbacks` entry's `model`, combined with the request's `output_config` one field at a time.<br/>
        /// - `format`: If you leave it out, the attempt uses the request's `format`. If you set it to `null`, the attempt runs without a format.<br/>
        /// - `effort`: If you leave it out, the attempt uses the request's `effort` when `model` supports that level with the attempt's `thinking`. If the request doesn't set `effort`, if `model` doesn't support the level, or if you set `effort` to `null`, the attempt runs at the default effort of `model`.<br/>
        /// - `task_budget`: If you leave it out, the attempt uses the request's `task_budget` when `model` accepts a task budget of that size. If the request doesn't set `task_budget`, if `model` doesn't accept it, or if you set `task_budget` to `null`, the attempt runs without a task budget.<br/>
        /// Set `output_config` to `null` to run the attempt without a format or a task budget, at the default effort of `model`.<br/>
        /// These rules apply with the `server-side-fallback-2026-07-01` beta header.
        /// </param>
        /// <param name="speed">
        /// The inference speed mode for the fallback attempt that uses this `fallbacks` entry's `model`. If you leave it out, the attempt runs at `fast` speed only when the request sets `speed` to `fast` and your organization can use fast mode on `model`.<br/>
        /// Otherwise, or when you set this field to `null`, the attempt runs at `standard` speed.<br/>
        /// These rules apply with the `server-side-fallback-2026-07-01` beta header.
        /// </param>
        /// <param name="thinking">
        /// The thinking configuration for the fallback attempt that uses this `fallbacks` entry's `model`. If you leave it out, the attempt uses the request's `thinking` when `model` supports that thinking `type`.<br/>
        /// If you leave it out and the request's thinking `type` is `between_tools` but `model` doesn't support `between_tools`, the attempt uses `disabled` if `model` supports it. Otherwise, if `model` doesn't support the request's thinking `type`, if the request doesn't set `thinking`, or if you set this field to `null`, the attempt uses the thinking `type` that `model` uses when a request leaves out `thinking`. The request's `thinking.display` still applies where `model` allows it.<br/>
        /// These rules apply with the `server-side-fallback-2026-07-01` beta header.
        /// </param>
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