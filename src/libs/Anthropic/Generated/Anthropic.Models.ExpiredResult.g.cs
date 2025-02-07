
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExpiredResult
    {
        /// <summary>
        /// Default Value: expired
        /// </summary>
        /// <default>global::Anthropic.ExpiredResultType.Expired</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.ExpiredResultTypeJsonConverter))]
        public global::Anthropic.ExpiredResultType Type { get; set; } = global::Anthropic.ExpiredResultType.Expired;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExpiredResult" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: expired
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExpiredResult(
            global::Anthropic.ExpiredResultType type = global::Anthropic.ExpiredResultType.Expired)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExpiredResult" /> class.
        /// </summary>
        public ExpiredResult()
        {
        }
    }
}