
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// [JSON schema](https://json-schema.org/draft/2020-12) for this tool's input.<br/>
    /// This defines the shape of the `input` that your tool accepts and that the model will produce.
    /// </summary>
    public sealed partial class BetaResponseToolInputSchema
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("properties")]
        public object? Properties { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required")]
        public global::System.Collections.Generic.IList<string>? Required { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"object"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "object";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseToolInputSchema" /> class.
        /// </summary>
        /// <param name="properties"></param>
        /// <param name="required"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaResponseToolInputSchema(
            object? properties,
            global::System.Collections.Generic.IList<string>? required,
            string type = "object")
        {
            this.Properties = properties;
            this.Required = required;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseToolInputSchema" /> class.
        /// </summary>
        public BetaResponseToolInputSchema()
        {
        }

    }
}