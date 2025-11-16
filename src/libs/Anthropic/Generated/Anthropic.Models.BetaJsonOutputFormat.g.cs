
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaJsonOutputFormat
    {
        /// <summary>
        /// The JSON schema of the format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Schema { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaJsonOutputFormatTypeJsonConverter))]
        public global::Anthropic.BetaJsonOutputFormatType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaJsonOutputFormat" /> class.
        /// </summary>
        /// <param name="schema">
        /// The JSON schema of the format
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaJsonOutputFormat(
            object schema,
            global::Anthropic.BetaJsonOutputFormatType type)
        {
            this.Schema = schema ?? throw new global::System.ArgumentNullException(nameof(schema));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaJsonOutputFormat" /> class.
        /// </summary>
        public BetaJsonOutputFormat()
        {
        }
    }
}