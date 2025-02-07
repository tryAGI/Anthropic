
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaExpiredResult
    {
        /// <summary>
        /// Default Value: expired
        /// </summary>
        /// <default>global::Anthropic.BetaExpiredResultType.Expired</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaExpiredResultTypeJsonConverter))]
        public global::Anthropic.BetaExpiredResultType Type { get; set; } = global::Anthropic.BetaExpiredResultType.Expired;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaExpiredResult" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: expired
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaExpiredResult(
            global::Anthropic.BetaExpiredResultType type = global::Anthropic.BetaExpiredResultType.Expired)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaExpiredResult" /> class.
        /// </summary>
        public BetaExpiredResult()
        {
        }
    }
}