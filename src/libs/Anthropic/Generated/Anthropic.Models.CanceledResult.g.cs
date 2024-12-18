
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CanceledResult
    {
        /// <summary>
        /// Default Value: canceled
        /// </summary>
        /// <default>global::Anthropic.CanceledResultType.Canceled</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.CanceledResultTypeJsonConverter))]
        public global::Anthropic.CanceledResultType Type { get; set; } = global::Anthropic.CanceledResultType.Canceled;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CanceledResult" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: canceled
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CanceledResult(
            global::Anthropic.CanceledResultType type = global::Anthropic.CanceledResultType.Canceled)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CanceledResult" /> class.
        /// </summary>
        public CanceledResult()
        {
        }
    }
}