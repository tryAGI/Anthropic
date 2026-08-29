
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaDataResidencyCreateParams
    {
        /// <summary>
        /// Permitted inference geo values. Defaults to 'unrestricted' if omitted, which allows all geos. Use the string 'unrestricted' to allow all geos, or a list of specific geos.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_inference_geos")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Anthropic.BetaAllowedInferenceGeo>, string, object>))]
        public global::Anthropic.AnyOf<global::System.Collections.Generic.IList<global::Anthropic.BetaAllowedInferenceGeo>, string, object>? AllowedInferenceGeos { get; set; }

        /// <summary>
        /// Default inference geo applied when requests omit the parameter. Defaults to 'global' if omitted. Must be a member of `allowed_inference_geos` unless `allowed_inference_geos` is `"unrestricted"`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_inference_geo")]
        public global::Anthropic.BetaInferenceGeo? DefaultInferenceGeo { get; set; }

        /// <summary>
        /// Geographic region for workspace data storage. Immutable after creation. Defaults to 'us' if omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_geo")]
        public global::Anthropic.BetaWorkspaceGeo? WorkspaceGeo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaDataResidencyCreateParams" /> class.
        /// </summary>
        /// <param name="allowedInferenceGeos">
        /// Permitted inference geo values. Defaults to 'unrestricted' if omitted, which allows all geos. Use the string 'unrestricted' to allow all geos, or a list of specific geos.
        /// </param>
        /// <param name="defaultInferenceGeo">
        /// Default inference geo applied when requests omit the parameter. Defaults to 'global' if omitted. Must be a member of `allowed_inference_geos` unless `allowed_inference_geos` is `"unrestricted"`.
        /// </param>
        /// <param name="workspaceGeo">
        /// Geographic region for workspace data storage. Immutable after creation. Defaults to 'us' if omitted.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaDataResidencyCreateParams(
            global::Anthropic.AnyOf<global::System.Collections.Generic.IList<global::Anthropic.BetaAllowedInferenceGeo>, string, object>? allowedInferenceGeos,
            global::Anthropic.BetaInferenceGeo? defaultInferenceGeo,
            global::Anthropic.BetaWorkspaceGeo? workspaceGeo)
        {
            this.AllowedInferenceGeos = allowedInferenceGeos;
            this.DefaultInferenceGeo = defaultInferenceGeo;
            this.WorkspaceGeo = workspaceGeo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaDataResidencyCreateParams" /> class.
        /// </summary>
        public BetaDataResidencyCreateParams()
        {
        }

    }
}