
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Specifies the geographic region for inference processing. If not specified, the workspace's `default_inference_geo` is used.
    /// </summary>
    public sealed partial class CreateMessageParamsWithoutStreamInferenceGeo
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}