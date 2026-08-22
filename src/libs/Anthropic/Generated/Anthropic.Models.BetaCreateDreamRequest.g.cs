
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaCreateDreamRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.BetaDreamInput> Inputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaDreamModelParamsJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaDreamModelParams Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_behavior")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaOutputBehaviorJsonConverter))]
        public global::Anthropic.BetaOutputBehavior? OutputBehavior { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCreateDreamRequest" /> class.
        /// </summary>
        /// <param name="inputs"></param>
        /// <param name="model"></param>
        /// <param name="instructions"></param>
        /// <param name="outputBehavior"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaCreateDreamRequest(
            global::System.Collections.Generic.IList<global::Anthropic.BetaDreamInput> inputs,
            global::Anthropic.BetaDreamModelParams model,
            string? instructions,
            global::Anthropic.BetaOutputBehavior? outputBehavior)
        {
            this.Inputs = inputs ?? throw new global::System.ArgumentNullException(nameof(inputs));
            this.Model = model;
            this.Instructions = instructions;
            this.OutputBehavior = outputBehavior;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCreateDreamRequest" /> class.
        /// </summary>
        public BetaCreateDreamRequest()
        {
        }

    }
}