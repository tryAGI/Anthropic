
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Model capability information.
    /// </summary>
    public sealed partial class BetaModelCapabilities
    {
        /// <summary>
        /// Whether the model supports the Batch API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batch")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaCapabilitySupport Batch { get; set; }

        /// <summary>
        /// Whether the model supports citation generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("citations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaCapabilitySupport Citations { get; set; }

        /// <summary>
        /// Whether the model supports code execution tools.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_execution")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaCapabilitySupport CodeExecution { get; set; }

        /// <summary>
        /// Context management support and available strategies.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_management")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaContextManagementCapability ContextManagement { get; set; }

        /// <summary>
        /// Effort (reasoning_effort) support and available levels.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effort")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaEffortCapability Effort { get; set; }

        /// <summary>
        /// Whether the model accepts image content blocks.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaCapabilitySupport ImageInput { get; set; }

        /// <summary>
        /// Whether the model accepts PDF content blocks.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pdf_input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaCapabilitySupport PdfInput { get; set; }

        /// <summary>
        /// Whether the model supports structured output / JSON mode / strict tool schemas.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("structured_outputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaCapabilitySupport StructuredOutputs { get; set; }

        /// <summary>
        /// Thinking capability and supported type configurations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thinking")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaThinkingCapability Thinking { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaModelCapabilities" /> class.
        /// </summary>
        /// <param name="batch">
        /// Whether the model supports the Batch API.
        /// </param>
        /// <param name="citations">
        /// Whether the model supports citation generation.
        /// </param>
        /// <param name="codeExecution">
        /// Whether the model supports code execution tools.
        /// </param>
        /// <param name="contextManagement">
        /// Context management support and available strategies.
        /// </param>
        /// <param name="effort">
        /// Effort (reasoning_effort) support and available levels.
        /// </param>
        /// <param name="imageInput">
        /// Whether the model accepts image content blocks.
        /// </param>
        /// <param name="pdfInput">
        /// Whether the model accepts PDF content blocks.
        /// </param>
        /// <param name="structuredOutputs">
        /// Whether the model supports structured output / JSON mode / strict tool schemas.
        /// </param>
        /// <param name="thinking">
        /// Thinking capability and supported type configurations.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaModelCapabilities(
            global::Anthropic.BetaCapabilitySupport batch,
            global::Anthropic.BetaCapabilitySupport citations,
            global::Anthropic.BetaCapabilitySupport codeExecution,
            global::Anthropic.BetaContextManagementCapability contextManagement,
            global::Anthropic.BetaEffortCapability effort,
            global::Anthropic.BetaCapabilitySupport imageInput,
            global::Anthropic.BetaCapabilitySupport pdfInput,
            global::Anthropic.BetaCapabilitySupport structuredOutputs,
            global::Anthropic.BetaThinkingCapability thinking)
        {
            this.Batch = batch ?? throw new global::System.ArgumentNullException(nameof(batch));
            this.Citations = citations ?? throw new global::System.ArgumentNullException(nameof(citations));
            this.CodeExecution = codeExecution ?? throw new global::System.ArgumentNullException(nameof(codeExecution));
            this.ContextManagement = contextManagement ?? throw new global::System.ArgumentNullException(nameof(contextManagement));
            this.Effort = effort ?? throw new global::System.ArgumentNullException(nameof(effort));
            this.ImageInput = imageInput ?? throw new global::System.ArgumentNullException(nameof(imageInput));
            this.PdfInput = pdfInput ?? throw new global::System.ArgumentNullException(nameof(pdfInput));
            this.StructuredOutputs = structuredOutputs ?? throw new global::System.ArgumentNullException(nameof(structuredOutputs));
            this.Thinking = thinking ?? throw new global::System.ArgumentNullException(nameof(thinking));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaModelCapabilities" /> class.
        /// </summary>
        public BetaModelCapabilities()
        {
        }
    }
}