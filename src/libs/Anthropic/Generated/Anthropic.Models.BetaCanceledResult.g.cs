
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaCanceledResult
    {
        /// <summary>
        /// Default Value: canceled
        /// </summary>
        /// <default>global::Anthropic.BetaCanceledResultType.Canceled</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaCanceledResultTypeJsonConverter))]
        public global::Anthropic.BetaCanceledResultType Type { get; set; } = global::Anthropic.BetaCanceledResultType.Canceled;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCanceledResult" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: canceled
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaCanceledResult(
            global::Anthropic.BetaCanceledResultType type = global::Anthropic.BetaCanceledResultType.Canceled)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCanceledResult" /> class.
        /// </summary>
        public BetaCanceledResult()
        {
        }
    }
}