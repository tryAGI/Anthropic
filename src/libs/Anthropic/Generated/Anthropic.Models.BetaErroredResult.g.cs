
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaErroredResult
    {
        /// <summary>
        /// Default Value: errored
        /// </summary>
        /// <default>global::Anthropic.BetaErroredResultType.Errored</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaErroredResultTypeJsonConverter))]
        public global::Anthropic.BetaErroredResultType Type { get; set; } = global::Anthropic.BetaErroredResultType.Errored;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaErrorResponse Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaErroredResult" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: errored
        /// </param>
        /// <param name="error"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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