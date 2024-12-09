
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaInputSchema
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaInputSchemaTypeJsonConverter))]
        public global::Anthropic.BetaInputSchemaType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("properties")]
        public object? Properties { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaInputSchema" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="properties"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public BetaInputSchema(
            global::Anthropic.BetaInputSchemaType type,
            object? properties)
        {
            this.Type = type;
            this.Properties = properties;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaInputSchema" /> class.
        /// </summary>
        public BetaInputSchema()
        {
        }
    }
}