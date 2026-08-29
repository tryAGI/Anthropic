
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Inference geo used matching requests' `inference_geo` parameter if set, otherwise the workspace's `default_inference_geo`.<br/>
    /// For models that do not support specifying `inference_geo` the value is `"not_available"`. Always `null` if not grouping by inference geo.
    /// </summary>
    public sealed partial class BetaCostReportItemInferenceGeo
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}