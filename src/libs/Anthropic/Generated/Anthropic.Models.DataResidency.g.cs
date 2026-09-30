
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DataResidency
    {
        /// <summary>
        /// Permitted inference geo values. 'unrestricted' means all geos are allowed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_inference_geos")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Anthropic.AllowedInferenceGeo>, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.AnyOf<global::System.Collections.Generic.IList<global::Anthropic.AllowedInferenceGeo>, string> AllowedInferenceGeos { get; set; }

        /// <summary>
        /// Default inference geo applied when requests omit the parameter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_inference_geo")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.InferenceGeoJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.InferenceGeo DefaultInferenceGeo { get; set; }

        /// <summary>
        /// Geographic region for workspace data storage. Immutable after creation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_geo")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.WorkspaceGeoJsonConverter))]
        public global::Anthropic.WorkspaceGeo WorkspaceGeo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DataResidency" /> class.
        /// </summary>
        /// <param name="allowedInferenceGeos">
        /// Permitted inference geo values. 'unrestricted' means all geos are allowed.
        /// </param>
        /// <param name="defaultInferenceGeo">
        /// Default inference geo applied when requests omit the parameter.
        /// </param>
        /// <param name="workspaceGeo">
        /// Geographic region for workspace data storage. Immutable after creation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DataResidency(
            global::Anthropic.AnyOf<global::System.Collections.Generic.IList<global::Anthropic.AllowedInferenceGeo>, string> allowedInferenceGeos,
            global::Anthropic.InferenceGeo defaultInferenceGeo,
            global::Anthropic.WorkspaceGeo workspaceGeo)
        {
            this.AllowedInferenceGeos = allowedInferenceGeos;
            this.DefaultInferenceGeo = defaultInferenceGeo;
            this.WorkspaceGeo = workspaceGeo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataResidency" /> class.
        /// </summary>
        public DataResidency()
        {
        }

    }
}