
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// JSON Schema for custom tool input parameters.
    /// </summary>
    public sealed partial class BetaManagedAgentsCustomToolInputSchema
    {
        /// <summary>
        /// Must be 'object' for tool input schemas.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsCustomToolInputSchemaTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsCustomToolInputSchemaType? Type { get; set; }

        /// <summary>
        /// JSON Schema properties defining the tool's input parameters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("properties")]
        public global::Anthropic.BetaManagedAgentsStruct? Properties { get; set; }

        /// <summary>
        /// List of required property names.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required")]
        public global::System.Collections.Generic.IList<string>? Required { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsCustomToolInputSchema" /> class.
        /// </summary>
        /// <param name="type">
        /// Must be 'object' for tool input schemas.
        /// </param>
        /// <param name="properties">
        /// JSON Schema properties defining the tool's input parameters.
        /// </param>
        /// <param name="required">
        /// List of required property names.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsCustomToolInputSchema(
            global::Anthropic.BetaManagedAgentsCustomToolInputSchemaType? type,
            global::Anthropic.BetaManagedAgentsStruct? properties,
            global::System.Collections.Generic.IList<string>? required)
        {
            this.Type = type;
            this.Properties = properties;
            this.Required = required;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsCustomToolInputSchema" /> class.
        /// </summary>
        public BetaManagedAgentsCustomToolInputSchema()
        {
        }
    }
}