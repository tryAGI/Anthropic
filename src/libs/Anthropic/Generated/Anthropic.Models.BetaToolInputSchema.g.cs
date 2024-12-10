
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// [JSON schema](https://json-schema.org/) for this tool's input.<br/>
    /// This defines the shape of the `input` that your tool accepts and that the model will produce.
    /// </summary>
    public sealed partial class BetaToolInputSchema
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaToolInputSchema" /> class.
        /// </summary>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public BetaToolInputSchema(
 )
        {
        }
    }
}