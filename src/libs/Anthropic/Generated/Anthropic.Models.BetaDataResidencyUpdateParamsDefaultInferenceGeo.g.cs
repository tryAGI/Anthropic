
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Default inference geo applied when requests omit the parameter. Must be a member of `allowed_inference_geos` unless `allowed_inference_geos` is `"unrestricted"`.
    /// </summary>
    public sealed partial class BetaDataResidencyUpdateParamsDefaultInferenceGeo
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}