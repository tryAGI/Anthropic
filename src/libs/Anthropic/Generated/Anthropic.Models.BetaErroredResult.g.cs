
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaErroredResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaErrorResponse Error { get; set; }

        /// <summary>
        /// Default Value: errored
        /// </summary>
        /// <default>global::Anthropic.BetaErroredResultType.Errored</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaErroredResultTypeJsonConverter))]
        public global::Anthropic.BetaErroredResultType Type { get; set; } = global::Anthropic.BetaErroredResultType.Errored;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaErroredResult" /> class.
        /// </summary>
        /// <param name="error"></param>
        /// <param name="type">
        /// Default Value: errored
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaErroredResult(
            global::Anthropic.BetaErrorResponse error,
            global::Anthropic.BetaErroredResultType type = global::Anthropic.BetaErroredResultType.Errored)
        {
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaErroredResult" /> class.
        /// </summary>
        public BetaErroredResult()
        {
        }
    }
}